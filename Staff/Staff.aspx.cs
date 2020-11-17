using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project5.Staff
{
    public partial class Staff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void deliveryBtn_Click(object sender, EventArgs e)
        {
            SuhasServiceRef.Service1Client suhasService = new SuhasServiceRef.Service1Client("soapService");
            try
            {
                if (!String.IsNullOrWhiteSpace(zipcode1TB.Text) && !String.IsNullOrWhiteSpace(zipcode2TB.Text))//Send the request only when text box contain some data
                {
                    string zipcode1 = zipcode1TB.Text;
                    string zipcode2 = zipcode2TB.Text;
                    string result = suhasService.distanceCalulator(zipcode1, zipcode2);
                    deliveryResultTB.Text = result;
                }
                else
                {   //Display the error message here!
                    zipcode1TB.Text = "Please enter a valid String!";
                    zipcode2TB.Text = "Please enter a valid String!";
                }
            }
            catch (Exception ex)
            {

            }

        }

        protected void neareststoreBtn_Click(object sender, EventArgs e)
        {
            SuhasServiceRef.Service1Client suhasService = new SuhasServiceRef.Service1Client("soapService");
            try
            {
                if (!String.IsNullOrWhiteSpace(neareststoreTB.Text) && !String.IsNullOrWhiteSpace(neareststorezipcodeTB.Text))//Send the request only when text box contain some data
                {
                    string zipcode = neareststorezipcodeTB.Text;
                    string storename = neareststoreTB.Text;
                    string result = suhasService.findNearestStore(zipcode, storename);
                    nearestStoreResultTB.Text = result;
                }
                else
                {   //Display the error message here!
                    neareststorezipcodeTB.Text = "Please enter a valid String!";
                    neareststoreTB.Text = "Please enter a valid String!";
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}