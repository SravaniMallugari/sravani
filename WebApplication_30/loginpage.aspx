<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginpage.aspx.cs" Inherits="WebApplication_30.loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Panel ID="Panel1" runat="server">
                 <asp:Label ID="lblUserName" runat="server" Text="Enter User Name:"></asp:Label>

                 <asp:TextBox ID="txtusername" runat="server" ToolTip="Enter Username in caps"></asp:TextBox>
                 <br />
                 <br />
                 <asp:Label ID="Label1" runat="server" Text="Enter Password:"></asp:Label>
                 <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:Label ID="lblmessage" runat="server"></asp:Label>
                 <br />
                 <br />
                 <asp:Button ID="Button1" runat="server" Text="Button" />
            </asp:Panel>
            </div>
    </form>
</body>
</html>
