<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sertifika-talep-formu.aspx.cs" Inherits="Cisco.sertifika_talep_formu" %>

<%@ Register Src="~/cisco-cert-form.ascx" TagPrefix="uc1" TagName="ciscocertform" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ciscocertform runat="server" id="ciscocertform" />
    </div>
    </form>
</body>
</html>
