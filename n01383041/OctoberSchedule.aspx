<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OctoberSchedule.aspx.cs" Inherits="n01383041.OctoberSchedule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Schedule for the month of October</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Schedule for the month of October</h1>
        <div>
            <h2>Please select the days of the week you are able to do homework.</h2>
            <asp:CheckBoxList runat="server" ID="available_days_of_week">
                <asp:ListItem Value="Monday">Monday</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <section>
            <input type="submit" value="submit" />
        </section>
        <div id="resultbox" runat="server"></div>
    </form>
</body>
</html>
