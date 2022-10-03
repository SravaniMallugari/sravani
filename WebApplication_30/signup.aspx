<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits=" WebApplication_30.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="TextBox2">
            Enter the customer first name:<asp:TextBox ID="TextBox1" runat="server" Width="203px"></asp:TextBox>
            <br />
            <br />
            Enter the customer last name:<asp:TextBox ID="TextBox3" runat="server" Width="207px"></asp:TextBox>
            <br />
            <br />
            Enter the customer birth date:<asp:Calendar ID="Calendars" runat="server"></asp:Calendar>
            <asp:TextBox ID="TextBox8" runat="server" Width="207px"></asp:TextBox>
            <br />
            <br />
            Enter the customer city&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox5" runat="server" Width="217px"></asp:TextBox>
            <br />
            <br />
            Enter the customer state&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox6" runat="server" Width="222px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="List" PostBackUrl="~/customer.aspx" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox7" runat="server" Width="324px"></asp:TextBox>
            <br />
        </div>    </form>
</body>
</html>
