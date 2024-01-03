using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_2
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            int a = 3, b=6;
            Label1.Text = "Output of WebService: " + webService.Add(a, b).ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService();
            Single A = 6, B = 3;
            Label2.Text = "Output of WebService: " + webService.Subtract(A, B).ToString();
        }
    }
}