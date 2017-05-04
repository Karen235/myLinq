<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SelectbyLinq.aspx.cs" Inherits="SelectbyLinq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Insert" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" />
    
    </div>
    </form>
</body>
</html>
