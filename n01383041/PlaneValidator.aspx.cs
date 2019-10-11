using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01383041
{
    public partial class PlaneValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    double xValueChecker = Convert.ToDouble(x_value.Text);
                    double yValueChecker = Convert.ToDouble(y_value.Text);

                    if (xValueChecker > 0 && yValueChecker > 0)
                    {
                        quadrantbox.InnerHtml += "That point (" + xValueChecker + ", " + yValueChecker + ") is in Quadrant 1 <br>";
                    }
                    else if (xValueChecker > 0 && yValueChecker < 0)
                    {
                        quadrantbox.InnerHtml += "That point (" + xValueChecker + ", " + yValueChecker + ") is in Quadrant 4 <br>";
                    }
                    else if (xValueChecker < 0 && yValueChecker > 0)
                    {
                        quadrantbox.InnerHtml += "That point (" + xValueChecker + ", " + yValueChecker + ") is in Quadrant 2 <br>";
                    }
                    else
                    {
                        quadrantbox.InnerHtml += "That point (" + xValueChecker + ", " + yValueChecker + ") is in Quadrant 3 <br>";
                    }
                       
                }
            }
        }
        
    }
}