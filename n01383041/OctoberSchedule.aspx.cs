using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01383041
{
    public partial class OctoberSchedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                resultbox.InnerHtml += "You work on these days: <br>";
                foreach (ListItem availableDaysOfWeek in available_days_of_week.Items)
                {
                    if (availableDaysOfWeek.Selected == true)
                    {
                        resultbox.InnerHtml += availableDaysOfWeek.Value + "<br>";

                    }

                }


                for (int i = 1; i < 32; i++)
                {
                    if (i % 7 == 0)
                    {
                        if (available_days_of_week.SelectedValue == "Monday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Monday, I'll Do Homework<br>";
                        }
                        else if (available_days_of_week.SelectedValue != "Monday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Monday, I'm Free<br>";
                        }
                        
                    }
                    else if (i % 7 == 1)
                    {
                        if (available_days_of_week.SelectedValue == "Tuesday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Tuesday, I'll Do Homework<br>";
                        }
                       else if (available_days_of_week.SelectedValue != "Tuesday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Tuesday, I'm Free<br>";
                        }
                    }
                    else if (i % 7 == 2)
                    {
                        if (available_days_of_week.SelectedValue == "Wednesday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Wednesday, I'll Do Homework<br>";
                        }
                        else if (available_days_of_week.SelectedValue != "Wednesday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Wednesday, I'm Free<br>";
                        }
                    }
                    else if (i % 7 == 3)
                    {
                        if (available_days_of_week.SelectedValue == "Thursday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Thursday, I'll Do Homework<br>";
                        }
                        else if (available_days_of_week.SelectedValue != "Thursday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Thursday, I'm Free<br>";
                        }
                    }
                    else if (i % 7 == 4)
                    {
                        if (available_days_of_week.SelectedValue == "Friday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Friday, I'll Do Homework<br>";
                        }
                        else if (available_days_of_week.SelectedValue != "Friday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Friday, I'm Free<br>";
                        }
                    }
                    else if (i % 7 == 5)
                    {
                        if (available_days_of_week.SelectedValue == "Saturday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Saturday, I'll Do Homework<br>";
                        }
                        else if (available_days_of_week.SelectedValue != "Saturday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Saturday, I'm Free<br>";
                        }
                    }
                    else if (i % 7 == 6)
                    {
                        if (available_days_of_week.SelectedValue == "Sunday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Sunday, I'll Do Homework<br>";
                        }
                        else if (available_days_of_week.SelectedValue != "Sunday")
                        {
                            resultbox.InnerHtml += "Oct " + i + " is a Sunday, I'm Free<br>";
                        }
                    }
                }
            }


                
            }
        }
    }
