using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace project5
{
    public partial class StaffLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStaffLogin_Click(object sender, EventArgs e)
        {

            lblErrorLogin.Visible = false;

            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Staff.xml";
            string user = txtNameStaff.Text;
            string password = txtPassStaff.Text;
            string captcha = imgVerBox.Text.ToLower();

            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(password))
            {
                lblErrorLogin.Text = "Please enter username and password!";
                lblErrorLogin.Visible = true;
                return;

            }

            if (captcha != Session["CaptchaVerify"].ToString())
            {
                lblErrorLogin.Text = "Please enter correcct verification captcha code!";
                lblErrorLogin.Visible = true;
                return;
            }


            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);    // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    if (node["pwd"].InnerText == password)
                    {
                        if (Request.QueryString["ReturnUrl"] != null)
                        {
                            FormsAuthentication.RedirectFromLoginPage(txtNameStaff.Text, false);
                        }
                        else
                        {
                            //FormsAuthentication.SetAuthCookie(txtNameStaff.Text, false);
                            SignIn(user, false);
                            Response.Redirect("Staff/Staff.aspx");
                        }

                    }
                    else
                    {
                        lblErrorLogin.Text = "Please enter correct password";
                        lblErrorLogin.Visible = true;
                        return;
                    }
                }
            }
            lblErrorLogin.Text = "Please enter correct credentials.If you are a new user, Please register first.";
            lblErrorLogin.Visible = true;
            return;
        }
        private void SignIn(string username, bool createPersistentCookie)
        {
            var now = DateTime.UtcNow.ToLocalTime();
            TimeSpan expirationTimeSpan = FormsAuthentication.Timeout;

            var ticket = new FormsAuthenticationTicket(
                1,
                username,
                now,
                now.Add(expirationTimeSpan),
                createPersistentCookie,
                "Staff",
                FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);

            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
                encryptedTicket)
            {
                HttpOnly = true,
                Secure = FormsAuthentication.RequireSSL,
                Path = FormsAuthentication.FormsCookiePath
            };

            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }

            Response.Cookies.Add(cookie);
        }


    }
}