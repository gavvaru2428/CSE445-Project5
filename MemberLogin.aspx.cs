using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using PasswordProtection;

namespace project5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
            {
                if (Request.QueryString["ReturnUrl"].Contains("Staff"))
                {
                    Response.Redirect("~/StaffLogin.aspx");

                }
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnMemLogin_Click(object sender, EventArgs e)
        {
            lblErrorLogin.Visible = false;

            string filepath = HttpRuntime.AppDomainAppPath + @"\App_Data\Members.xml";
            string user = txtMemName.Text;

            string password = txtMemPass.Text;

            DllClass dllClass = new DllClass();

            string decryptPass = "";
            XmlDocument myDoc = new XmlDocument();
            myDoc.Load(filepath);    // open file
            XmlElement rootElement = myDoc.DocumentElement;
            foreach (XmlNode node in rootElement.ChildNodes)
            {
                if (node["name"].InnerText == user)
                {
                    decryptPass = dllClass.decryptString(node["pwd"].InnerText);

                    if (decryptPass.Equals(password))
                    {
                        if (Request.QueryString["ReturnUrl"] != null)
                        {
                            FormsAuthentication.RedirectFromLoginPage(txtMemName.Text, false);
                        }
                        else
                        {
                            FormsAuthentication.SetAuthCookie(txtMemName.Text, false);
                            Response.Redirect("Members/Member.aspx");
                        }

                        
                      
                    }
                    else
                    {
                        //if username exists but password does match. 
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
    }
}