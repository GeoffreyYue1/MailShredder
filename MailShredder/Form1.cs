using Microsoft.Exchange.WebServices.Data;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MailShredder
{


    public partial class FormMain : Form
    {
        static ExchangeService service;
        static string logFilePath = string.Empty;
        static string csvFilePath = string.Empty;
        static string mailbox = "";

        public FormMain()
        {
            InitializeComponent();


        }

        private void rdb_EnvOnprem_CheckedChanged(object sender, EventArgs e)
        {

            txt_OnpremDomain.Enabled = rdb_EnvOnprem.Checked;
            txt_OnpremEWSUrl.Enabled = rdb_EnvOnprem.Checked;
            txt_OnpremPwd.Enabled = rdb_EnvOnprem.Checked;
            txt_OnpremUser.Enabled = rdb_EnvOnprem.Checked;


        }

        private void FormMain_Load(object sender, EventArgs e)
        {



            //txt_OnpremEWSUrl.Text = "https://<yourdomain>/EWS/Exchange.asmx";


            txt_OnpremDomain.Text = "ex16";
            txt_OnpremUser.Text = "Admin001";
            txt_OnpremPwd.Text = "Password1!";
            txt_OnpremEWSUrl.Text = "https://Ex16aio.ex16.com/EWS/Exchange.asmx";

            rdb_EnvO365.Checked = true;
            rdb_EnvOnprem.Checked = true;

            rdb_KW_MwssageId.Checked = true;
            rdb_KW_Subject.Checked = true;

            txt_KW_End.Text = DateTime.Today.ToString("yyyy-MM-dd") + " 23:59:59";
            txt_KW_Start.Text = DateTime.Today.AddMonths(-1).ToString("yyyy-MM-dd") + " 00:00:00";

            pb_Progress.Visible = false;
            lbl_Progress.Visible = false;
            HideAlert();


            LoadUserDefaultSettings();


        }
        private void HideAlert()
        {
            lbl_AlertMailbox.Visible = false;
            lbl_AlertMessageID.Visible = false;
            lbl_AlertSubject.Visible = false;
            lbl_AlertStart.Visible = false;
            lbl_AlertEnd.Visible = false;
        }
        private void rdb_EnvO365_CheckedChanged(object sender, EventArgs e)
        {
            txt_O365TenantId.Enabled = rdb_EnvO365.Checked;
            txt_O365ApplicationId.Enabled = rdb_EnvO365.Checked;
            txt_O365ClientCredential.Enabled = rdb_EnvO365.Checked;

        }

        private void rdb_KW_MwssageId_CheckedChanged(object sender, EventArgs e)
        {
            txt_KW_MessageID.Enabled = rdb_KW_MwssageId.Checked;
        }

        private void rdb_KW_Subject_CheckedChanged(object sender, EventArgs e)
        {
            txt_KW_Subject.Enabled = rdb_KW_Subject.Checked;
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {


            logFilePath = "MailShredderLog_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            csvFilePath = "MailList_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";
            AddRecord("FindInMailbox", "Subject", "RecievedDate", "To", "CC");

            HideAlert();

            if (!ValidateValue())
            {
                MessageBox.Show("Please input the required field.");
                return;
            }

            pb_Progress.Visible = true;
            lbl_Progress.Visible = true;
            pb_Progress.Value = 0;
            lbl_Progress.Text = "0%";



            service = new ExchangeService(ExchangeVersion.Exchange2013);

            //service.TraceEnabled = true;
            //service.TraceFlags = TraceFlags.All;

            if (rdb_EnvOnprem.Checked)
            {
                GenerateServiceForOnpremEnv();
            }
            else
            {
                if (cbx_21V.Checked)
                {

                    if (!GenerateServiceFor21V())
                    {
                        MessageBox.Show("Request AccessToken failed, please check your application registration and settings");
                        return;
                    }
                }
                else
                {
                    if (!GenerateServiceForO365Env())
                    {
                        MessageBox.Show("Request AccessToken failed, please check your application registration and settings");
                        return;
                    }
                }
            }

            service.Timeout = 900000;

            System.Net.ServicePointManager.ServerCertificateValidationCallback = (sender1, certificate, chain, sslPolicyErrors) => true;

            string[] mailboxlist = txt_MailboxList.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);



            SearchFilter.SearchFilterCollection messageSearchFilter = new SearchFilter.SearchFilterCollection(LogicalOperator.And);

            SearchFilter.ContainsSubstring messageFilter;
            if (rdb_KW_Subject.Checked)
            {
                messageFilter = new SearchFilter.ContainsSubstring(EmailMessageSchema.Subject, txt_KW_Subject.Text.Trim(), ContainmentMode.Substring, ComparisonMode.IgnoreCase);

            }
            else
            {

                messageFilter = new SearchFilter.ContainsSubstring(EmailMessageSchema.InternetMessageId, txt_KW_MessageID.Text.Trim(), ContainmentMode.Substring, ComparisonMode.IgnoreCase);
            }
            messageSearchFilter.Add(messageFilter);

            if (!string.IsNullOrEmpty(txt_KW_Start.Text.Trim()))
            {

                SearchFilter.IsGreaterThanOrEqualTo startFilter = new SearchFilter.IsGreaterThanOrEqualTo(EmailMessageSchema.DateTimeReceived, DateTime.Parse(txt_KW_Start.Text.Trim()));
                messageSearchFilter.Add(startFilter);
            }

            if (!string.IsNullOrEmpty(txt_KW_End.Text.Trim()))
            {

                SearchFilter.IsLessThanOrEqualTo endFilter = new SearchFilter.IsLessThanOrEqualTo(EmailMessageSchema.DateTimeReceived, DateTime.Parse(txt_KW_End.Text.Trim()));
                messageSearchFilter.Add(endFilter);
            }


            // Create a view with a page size of 2000.
            FolderView view = new FolderView(2000);

            // Identify the properties to return in the results set.
            view.PropertySet = new PropertySet(BasePropertySet.IdOnly);
            view.PropertySet.Add(FolderSchema.DisplayName);

            // Return only folders that contain items.
            SearchFilter searchFilter = new SearchFilter.IsGreaterThan(FolderSchema.TotalCount, 0);

            // Unlike FindItem searches, folder searches can be deep traversals.
            view.Traversal = FolderTraversal.Deep;


            for (int i = 0; i < mailboxlist.Length; i++)
            {
                string mailAddress = mailboxlist[i].Trim();
                mailbox = mailAddress;
                WriteLog("scan for user: " + mailAddress);
                if (string.IsNullOrEmpty(mailAddress))
                    continue;

                service.ImpersonatedUserId = new ImpersonatedUserId(ConnectingIdType.SmtpAddress, mailAddress);

                service.HttpHeaders.Add("X-AnchorMailbox", mailAddress);
                // Send the request to search the mailbox and get the results.
                try
                {
                    FindFoldersResults findFolderResults = service.FindFolders(WellKnownFolderName.MsgFolderRoot, searchFilter, view);
                    // Process each item.


                    foreach (Folder myFolder in findFolderResults.Folders)
                    {


                        DeleteMessage(service, myFolder.Id, messageSearchFilter);

                        // Console.WriteLine("\nName: " + myFolder.DisplayName + "\n  Id: " + myFolder.Id);

                    }
                }

                catch (Exception ex)
                {
                    WriteLog(string.Format("---Exception for recipient: {0}", mailAddress));
                    WriteLog(ex.Message);
                    WriteLog("");
                }

                service.HttpHeaders.Remove("X-AnchorMailbox");

                double progress = ((double)(i + 1) / (double)mailboxlist.Length) * 100;

                pb_Progress.Value = (int)progress;
                lbl_Progress.Text = Math.Round(progress, 0).ToString() + "%";
            }




        }
        private bool ValidateValue()
        {
            bool validatePass = true;
            if (rdb_KW_MwssageId.Checked & string.IsNullOrEmpty(txt_KW_MessageID.Text.Trim()))
            {
                validatePass = false;
                lbl_AlertMessageID.Visible = true;
            }

            if (rdb_KW_Subject.Checked & string.IsNullOrEmpty(txt_KW_Subject.Text.Trim()))
            {
                validatePass = false;
                lbl_AlertSubject.Visible = true;
            }

            if (string.IsNullOrEmpty(txt_MailboxList.Text.Trim()))
            {
                validatePass = false;
                lbl_AlertMailbox.Visible = true;
            }
            if (!string.IsNullOrEmpty(txt_KW_Start.Text.Trim()))
            {
                DateTime start;
                if (!DateTime.TryParse(txt_KW_Start.Text.Trim(), out start))
                {
                    validatePass = false;
                    lbl_AlertStart.Visible = true;
                }
            }

            if (!string.IsNullOrEmpty(txt_KW_End.Text.Trim()))
            {
                DateTime end;
                if (!DateTime.TryParse(txt_KW_End.Text.Trim(), out end))
                {
                    validatePass = false;
                    lbl_AlertEnd.Visible = true;
                }
            }

            return validatePass;

        }
        private void DeleteMessage(ExchangeService service, FolderId folderId, SearchFilter filter)
        {
            // Limit the result set to 10 items.



            ItemView view = new ItemView(100);



            view.PropertySet = new PropertySet(ItemSchema.Subject,
                                               ItemSchema.DateTimeReceived,
                                               ItemSchema.DisplayTo,
                                               ItemSchema.DisplayCc


                                               );

            // Item searches do not support Deep traversal.
            view.Traversal = ItemTraversal.Shallow;
            // Sorting.
            view.OrderBy.Add(ItemSchema.DateTimeReceived, SortDirection.Descending);
            try
            {
                FindItemsResults<Item> results = service.FindItems(folderId, filter, view);
                foreach (Item item in results.Items)
                {

                    //EmailMessage message = item as EmailMessage;

                    AddRecord(mailbox, item.Subject, item.DateTimeReceived.ToString(), item.DisplayTo, item.DisplayCc);

                    if (!cbx_CalculateOnly.Checked)
                    {
                        item.Delete(DeleteMode.HardDelete);
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("---Exception while enumerating results: {0}", ex.Message);
            }
        }

        private bool GenerateServiceFor21V()
        {
            try
            {
                GlobalVar21V O365GlobalVar21V = new GlobalVar21V(txt_O365TenantId.Text.Trim(), txt_O365ApplicationId.Text.Trim(), txt_O365ClientCredential.Text.Trim());



                string token = O365GlobalVar21V.RequestToken();

                service.Credentials = new OAuthCredentials(token);
                service.Url = new Uri("https://partner.outlook.cn/ews/exchange.asmx");
            }
            catch (Exception ex)
            {
                WriteLog("Request Token Failed");
                WriteLog(ex.ToString());
                return false;
            }
            return true;

        }

        private bool GenerateServiceForO365Env()
        {
            try {
                GlobalVar O365GlobalVar = new GlobalVar(txt_O365TenantId.Text.Trim(), txt_O365ApplicationId.Text.Trim(), txt_O365ClientCredential.Text.Trim());



                string token = O365GlobalVar.RequestToken();

                service.Credentials = new OAuthCredentials(token);
                service.Url = new Uri("https://outlook.office365.com/ews/exchange.asmx");
            } catch (Exception ex)
            {
                WriteLog("Request Token Failed");
                WriteLog(ex.ToString());
                return false;
            }
            return true;

        }
        private void GenerateServiceForOnpremEnv()
        {
            if (txt_OnpremUser.Text.Contains("@"))
            {
                service.Credentials = new WebCredentials(txt_OnpremUser.Text.Trim(), txt_OnpremPwd.Text.Trim());

            }
            else
            {
                service.Credentials = new WebCredentials(txt_OnpremUser.Text.Trim(), txt_OnpremPwd.Text.Trim(), txt_OnpremDomain.Text.Trim());

            }
            service.Url = new Uri(txt_OnpremEWSUrl.Text.Trim());
        }

        private void btn_BrowseMailboxList_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Select a txt file";
            openFileDialog1.Filter = "Txt files(*.txt) | *.txt";
            openFileDialog1.Title = "Open Mailbox list txt file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_MailboxList.Text = File.ReadAllText(openFileDialog1.FileName);
            }

        }

        private void WriteLog(string loginfo)
        {
            File.AppendAllText(logFilePath, loginfo);
            File.AppendAllText(logFilePath, "\r\n");
        }


        private void AddRecord(string Mailbox, string Subject, string Date, string ToRecipient, string CcRecipient)
        {
            try
            {

                File.AppendAllText(csvFilePath, Mailbox + "," + Subject + "," + Date + "," + ToRecipient + "," + CcRecipient);
                File.AppendAllText(csvFilePath, "\r\n");
                WriteLog(Mailbox + "," + Subject + "," + Date + "," + ToRecipient + "," + CcRecipient);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program did an oopsie :", ex);
            }
        }

        private void LoadUserDefaultSettings()
        {
            if (!File.Exists("usersetting.config"))
            {
                MessageBox.Show("usersetting.config not exists, please input your settings and save it to generate your settings file");
                return;
            }
            string userSettingsString = File.ReadAllText("usersetting.config");

            UserSettings usersettings = JsonConvert.DeserializeObject<UserSettings>(userSettingsString);


            if (usersettings.env == "onprem")
            {
                rdb_EnvOnprem.Checked = true;

            }
            else
            {
                rdb_EnvO365.Checked = true;
            }
            txt_OnpremDomain.Text = usersettings.domain;
            txt_OnpremUser.Text = usersettings.user.Trim();
            txt_OnpremPwd.Text = usersettings.pwd.Trim();
            txt_OnpremEWSUrl.Text = usersettings.ewsUrl.Trim();
            txt_O365TenantId.Text = usersettings.tenantId.Trim();
            txt_O365ApplicationId.Text = usersettings.applicationId.Trim();
            txt_O365ClientCredential.Text = usersettings.secret.Trim();
            txt_KW_Start.Text = usersettings.start.Trim();
            txt_KW_End.Text = usersettings.end.Trim();
            if (usersettings.keywordType == "mid")
            {
                rdb_KW_MwssageId.Checked = true;
            }
            else
            {
                rdb_KW_Subject.Checked = true;
            }
            txt_KW_MessageID.Text = usersettings.messageId.Trim();
            txt_KW_Subject.Text = usersettings.subject.Trim();
            txt_MailboxList.Text = usersettings.Mailboxlist.Trim();
            if (usersettings.calculateonly == "Y")
            {
                cbx_CalculateOnly.Checked = true;
            }
            else
            {
                cbx_CalculateOnly.Checked = false;
            }

        }
        private void loadDefaultSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserDefaultSettings();

        }

        private void saveCurrentSettingAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettings usersettings = new UserSettings();

            if (rdb_EnvOnprem.Checked)
            {
                usersettings.env = "onprem";

            }else
            {
                usersettings.env = "o365";
            }
            usersettings.domain = txt_OnpremDomain.Text.Trim();
            usersettings.user = txt_OnpremUser.Text.Trim();
            usersettings.pwd = txt_OnpremPwd.Text.Trim();
            usersettings.ewsUrl = txt_OnpremEWSUrl.Text.Trim();
            usersettings.tenantId = txt_O365TenantId.Text.Trim();
            usersettings.applicationId = txt_O365ApplicationId.Text.Trim();
            usersettings.secret = txt_O365ClientCredential.Text.Trim();
            usersettings.start = txt_KW_Start.Text.Trim();
            usersettings.end = txt_KW_End.Text.Trim();
            if(rdb_KW_MwssageId.Checked)
            {
                usersettings.keywordType = "mid";
            }else
            {
                usersettings.keywordType = "sub";
            }
            usersettings.messageId = txt_KW_MessageID.Text.Trim();
            usersettings.subject = txt_KW_Subject.Text.Trim();
            usersettings.Mailboxlist = txt_MailboxList.Text.Trim();
            if(cbx_CalculateOnly.Checked)
            {
                usersettings.calculateonly = "Y";
            }
            else
            {
                usersettings.calculateonly = "N";
            }

            string userSettingsString = JsonConvert.SerializeObject(usersettings);
            File.WriteAllText("usersetting.config", userSettingsString);
            

        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please send a mail to Geoffrey@microsoft.com and yuqing.zhang@microsoft.com if you get problem when using this tool");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/exchange/client-developer/exchange-web-services/how-to-authenticate-an-ews-application-by-using-oauth");
        }

        private void cbx_21V_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    class UserSettings
    {
        public string env;
        public string domain;
        public string user;
        public string pwd;
        public string ewsUrl;
        public string tenantId;
        public string applicationId;
        public string secret;
        public string start;
        public string end;
        public string keywordType;
        public string messageId;
        public string subject;
        public string Mailboxlist;
        public string calculateonly;

    }
    class GlobalVar21V
    {
        public string adTenant = "";
        public string clientId = "";
        public string secret = "";
        public string tokenAuthority;
        public string body;
        public string resource = "https://partner.outlook.cn/";
        public string token = string.Empty;
        public GlobalVar21V(string tenantId, string applicationId, string clientSecret)
        {
            adTenant = tenantId;
            clientId = applicationId;
            secret = clientSecret;
            string secret_encoded = HttpUtility.UrlEncode(secret);
            tokenAuthority = "https://login.chinacloudapi.cn/" + adTenant;

        }

        public string RequestToken()
        {
            Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationContext authContext = new Microsoft.IdentityModel.Clients.ActiveDirectory.AuthenticationContext(tokenAuthority);
            ClientCredential clientCredential = new ClientCredential(clientId, secret);

            var authresult = authContext.AcquireTokenAsync(resource, clientCredential).Result;



            token = authresult.AccessToken;
            return token;
        }




        //public static string tokenAuthority = "https://login.microsoftonline.com/" + adTenant + "/oauth2/v2.0/token";



        
    }

    class GlobalVar
    {
        public  string adTenant = "";
        public  string clientId = "";
        public  string secret = "";
        public string tokenAuthority;
        public string body;
        public string resource = "https://outlook.office365.com/";
        public GlobalVar(string tenantId, string applicationId, string clientSecret)
        {
            adTenant = tenantId;
            clientId = applicationId;
            secret = clientSecret;
            string secret_encoded = HttpUtility.UrlEncode(secret);
            tokenAuthority = "https://login.windows.net/" + adTenant + "/oauth2/token";
            body = "resource=" + resource + "&client_id=" + clientId + "&client_secret=" + secret_encoded + "&grant_type=client_credentials";
        }

        public string RequestToken()
        {
            HttpContent content = new StringContent(body , Encoding.UTF8, "application/x-www-form-urlencoded");


            HttpClient httpClient = new HttpClient();

            var response = httpClient.PostAsync(tokenAuthority, content).Result;

            var contents = response.Content.ReadAsStringAsync().Result;

            TokenResult tokenResult = JsonConvert.DeserializeObject<TokenResult>(contents);

          token = tokenResult.access_token;
            return token;
        }

       

       
        //public static string tokenAuthority = "https://login.microsoftonline.com/" + adTenant + "/oauth2/v2.0/token";


       
        public  string token = string.Empty;
    }

    public class TokenResult
    {
        public string token_type;
        public string scope;
        public string expires_in;
        public string ext_expires_in;
        public string expires_on;
        public string not_before;
        public string resource;
        public string access_token;
        public string refresh_token;
        public string id_token;


    }

   

}
