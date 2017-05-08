<%@ Page Language="VB" AutoEventWireup="false" CodeFile="LogIn.aspx.vb" Inherits="LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    
<body>
    <form id="form1"  runat="server">
    <div style="background-image:url('images\BI.jpg');">
    
    
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 663px; top: 301px; position: absolute" Text="Close" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 449px; top: 205px; position: absolute; height: 19px" Text="Password"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 460px; top: 152px; position: absolute; height: 19px;" Text="User ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 591px; top: 147px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 590px; top: 202px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 561px; top: 301px; position: absolute" Text="Log In" />
        </p>
    </form>
    </div>
   
body {
  background-image: url('images\BI.jpg');
            height: 7px;
        }

</body>
       
</html>
