using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01383041
{
    public partial class Raffle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    int numberOfTickets = Convert.ToInt32(number_of_tickets.Text);

                    for (int i = 1; i <= numberOfTickets ; i++)
                    {
                        if (numberOfTickets < 52)
                        {
                            resultbox.InnerHtml += "You receive bundle of 1! That's "+ i +" ticket(s)<br>";   
                        }
                        else if (numberOfTickets < 151 && i%2==0)
                        {                                
                                resultbox.InnerHtml += "You receive bundle of 2! That's " + (i + 1) + " ticket(s)<br>";
                                i++;
                        }
                        else if (numberOfTickets < 301 && i%3==0)
                        {
                            resultbox.InnerHtml += "You receive bundle of 3! That's " + (i+2) + " ticket(s)<br>";
                            i+=2;
                        }
                        else if(numberOfTickets > 301 && i%5==0)
                        {
                            resultbox.InnerHtml += "You receive bundle of 5! That's " + (i+4) + " ticket(s)<br>";
                            i += 4;
                        }
                        else
                        {
                            resultbox.InnerHtml += "Your leftover is " + (numberOfTickets - i) + " tickets. That's " + i + " ticket(s)!<br>";
                        }
                    }
                    resultbox.InnerHtml += "Your total ticket(s) is "+ numberOfTickets +" and your cost is $"+ (numberOfTickets * 0.25)+ " CND";

                }
            }
        }
    }
}