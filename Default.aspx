<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!doctype html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0" />
    <title>SweetAlert for .NET</title>
    <script src="https://code.jquery.com/jquery-2.1.3.min.js"></script>
    <script src="js/sweetalert-dev.js"></script>
    <link rel="stylesheet" href="css/sweetalert.css">
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Show Error</asp:LinkButton><br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Show Success</asp:LinkButton><br />
        </div>
    </form>
</body>
</html>
