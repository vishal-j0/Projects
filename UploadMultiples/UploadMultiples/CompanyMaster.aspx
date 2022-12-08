<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanyMaster.aspx.cs" Inherits="UploadMultiples.fileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label2" runat="server" Text="Enter Your Name"></asp:Label>  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
             <asp:FileUpload ID="FileUpload1" AllowMultiple="true" runat="server" /> <br />
            <asp:Button ID="Button1" runat="server"  Text="Submit" OnClick="Button1_Click" /> <br />
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            
            
           
            
        </div>
    </form>
</body>
</html>
