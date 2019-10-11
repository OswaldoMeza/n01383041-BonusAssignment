<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle.aspx.cs" Inherits="n01383041.Raffle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTTP Raffle</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Raffle for a Laptop</h1>
            <h2>Each raffle ticket cost $0.25 CND, how many would you like to purchase? </h2>
            <label>Number of Tickets:</label>
            <asp:TextBox runat="server" ID="number_of_tickets"></asp:TextBox>
                <asp:CompareValidator
                runat="server"
                EnabelClientScript="true"
                Type="Integer"
                ControlToValidate="number_of_tickets"
                ValueToCompare="0"
                Operator="NotEqual"
                ErrorMessage="please enter a number that is not a decimal and not 0">
            </asp:CompareValidator>
        </div>
        <div id="resultbox" runat="server"></div>
    </form>
</body>
</html>
