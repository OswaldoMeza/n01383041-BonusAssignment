<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaneValidator.aspx.cs" Inherits="n01383041.PlaneValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cartesian Plane Point Locator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cartesian Plane Point Locator</h1>
            <h2>Please select an "x-value" and "y-value" to find out which quadrant it belongs too. </h2>
            <label>X-Value</label>
            <asp:TextBox runat="server" ID="x_value"></asp:TextBox>
            <asp:CompareValidator
                runat="server"
                EnabelClientScript="true"
                Type="Double"
                ControlToValidate="x_value"
                ValueToCompare="0"
                Operator="NotEqual"
                ErrorMessage="x-value cannot be 0">
            </asp:CompareValidator>
            <div>
                <label>Y-Value</label>
                <asp:TextBox runat="server" ID="y_value"></asp:TextBox>
                <asp:CompareValidator
                    runat="server"
                    EnabelClientScript="true"
                    Type="Double"
                    ControlToValidate="y_value"
                    ValueToCompare="0"
                    Operator="NotEqual"
                    ErrorMessage="y-value cannot be 0">
                </asp:CompareValidator>
           </div>
        </div>
        <section>
            <input type="submit" value="submit" />
        </section>
        <div id="quadrantbox" runat="server">

        </div>
    </form>
</body>
</html>
