<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="cisco-cert-form.ascx.cs" Inherits="Cisco.cisco_cert_form" %>
<style>
.area{

    text-align: center;
   
    }
</style>

<div class="area" >
<p>
    <a href="http://netacad.com" target="_blank">Netacad.com</a> kullanıcı bilgileriniz ile giriş yapınız..</p>
<p>
    Kullanıcı Adı&nbsp; :&nbsp;
    <asp:TextBox ID="txtName" runat="server" Width="190px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Bu alan boş geçilemez."></asp:RequiredFieldValidator>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; E - Mail&nbsp; :&nbsp;&nbsp;
    <asp:TextBox ID="txtMail" TextMode="Email" runat="server" Width="190px"></asp:TextBox>
&nbsp;
  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtMail" ErrorMessage="Bu alan boş geçilemez."></asp:RequiredFieldValidator>
</p>
<p>
    <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />
&nbsp;&nbsp;
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>

</div>