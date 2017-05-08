<%@ Page Language="VB" AutoEventWireup="false" CodeFile="GetSetTransaction.aspx.vb" Inherits="GetSetTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtEmployeeNum" runat="server" style="z-index: 1; left: 583px; top: 103px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 462px; top: 103px; position: absolute; height: 12px" Text="Employee No."></asp:Label>
        <asp:DropDownList ID="drpLocation" runat="server" style="z-index: 1; left: 584px; top: 57px; position: absolute; height: 24px; width: 135px">
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 461px; top: 151px; position: absolute" Text="Tool No."></asp:Label>
        <asp:TextBox ID="txtToolNum" runat="server" style="z-index: 1; left: 585px; top: 149px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 461px; top: 62px; position: absolute; height: 4px; right: 670px" Text="Location"></asp:Label>
    
    </div>
        <asp:GridView ID="DGViewTransaction" runat="server" style="z-index: 1; left: 329px; top: 269px; position: absolute; height: 133px; width: 699px">
        </asp:GridView>
        <asp:Button ID="btnShowDetails" runat="server" style="z-index: 1; left: 578px; top: 210px; position: absolute; width: 118px" Text="Show Details" />
        <asp:Button ID="btnReleaseTool" runat="server" style="z-index: 1; left: 586px; top: 448px; position: absolute" Text="Release Tool" />
        <asp:Label ID="lblDisplayStatus" runat="server" style="z-index: 1; left: 107px; top: 452px; position: absolute; width: 438px"></asp:Label>
    </form>
</body>
</html>
