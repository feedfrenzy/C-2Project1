<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="Project.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblDisplay" runat="server" ForeColor="#00CC00" style="z-index: 1; left: 275px; top: 191px; position: absolute; bottom: 455px" Text="Welcome CIS 3342 Demo Page"></asp:Label>
        <asp:TextBox ID="txtInput" runat="server" style="z-index: 1; left: 307px; top: 226px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 335px; top: 262px; position: absolute; height: 23px; width: 70px" Text="Submit" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
