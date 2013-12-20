<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultSidebar1.ascx.cs" Inherits="Sidebar1" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>

<asp:Panel ID="pnlLoginIn" runat="server">
<div class="art-block">
    <div class="art-block-tl"></div>
    <div class="art-block-tr"></div>
    <div class="art-block-bl"></div>
    <div class="art-block-br"></div>
    <div class="art-block-tc"></div>
    <div class="art-block-bc"></div>
    <div class="art-block-cl"></div>
    <div class="art-block-cr"></div>
    <div class="art-block-cc"></div>
    <div class="art-block-body">

<div class="art-blockheader">
    <div class="l"></div>
    <div class="r"></div>
    <h3 class="t">Kullanýcý Giriþi</h3>
</div>

<div class="art-blockcontent">
    <div class="art-blockcontent-tl"></div>
    <div class="art-blockcontent-tr"></div>
    <div class="art-blockcontent-bl"></div>
    <div class="art-blockcontent-br"></div>
    <div class="art-blockcontent-tc"></div>
    <div class="art-blockcontent-bc"></div>
    <div class="art-blockcontent-cl"></div>
    <div class="art-blockcontent-cr"></div>
    <div class="art-blockcontent-cc"></div>
    <div class="art-blockcontent-body"><div>
          <asp:Label  runat="server" Text="Kullanýcý Adý"></asp:Label>
          <br />
          <asp:TextBox ID="kulAd" runat="server"></asp:TextBox>
          <br />
          <asp:Label  runat="server" Text="Þifre"></asp:Label>
          <br />
          <asp:TextBox ID="kulPass" runat="server" TextMode="Password"></asp:TextBox>

          <span class="art-button-wrapper">
          	<span class="art-button-l"> </span>
          	<span class="art-button-r"> 
          <br />
          </span>
          <asp:Button class="art-button" ID="btnLogin" runat="server" Text="Login" 
              onclick="btnLogin_Click" />
          </span>
          <asp:Label ID="loginMsj" CssClass="loginMsj" runat="server" Text="Hatalý Kullanýcý Adý veya Þifre.." Visible="false"></asp:Label>
          
          </div>
<div class="cleared"></div>
    </div>
</div>


		<div class="cleared"></div>
    </div>
</div>
</asp:Panel>
<asp:Panel ID="pnlLoginOut" runat="server" Visible="false">
<div class="art-block">
    <div class="art-block-tl"></div>
    <div class="art-block-tr"></div>
    <div class="art-block-bl"></div>
    <div class="art-block-br"></div>
    <div class="art-block-tc"></div>
    <div class="art-block-bc"></div>
    <div class="art-block-cl"></div>
    <div class="art-block-cr"></div>
    <div class="art-block-cc"></div>
    <div class="art-block-body">

<div class="art-blockheader">
    <div class="l"></div>
    <div class="r"></div>
    <h3 class="t">Kullanýcý Yönetimi</h3>
</div>

<div class="art-blockcontent">
    <div class="art-blockcontent-tl"></div>
    <div class="art-blockcontent-tr"></div>
    <div class="art-blockcontent-bl"></div>
    <div class="art-blockcontent-br"></div>
    <div class="art-blockcontent-tc"></div>
    <div class="art-blockcontent-bc"></div>
    <div class="art-blockcontent-cl"></div>
    <div class="art-blockcontent-cr"></div>
    <div class="art-blockcontent-cc"></div>
    <div class="art-blockcontent-body">

    Merhaba,<strong><asp:Label ID="kulIsim" runat="server" /></strong><br/>
    <asp:LinkButton ID="btnLogOut" Text="Oturumu Kapat" runat="server" onclick="btnLogOut_Click" ></asp:LinkButton>



		<div class="cleared"></div>
    </div>
</div>


		<div class="cleared"></div>
    </div>
</div>
</asp:Panel>
<a href="http://mysismobile.com"><asp:Image ID="Image1" runat="server" ImageUrl="~/images/demo.png"/></a>
<mysis:Block ID="FaceBook" Caption="Facebook" runat="server">
    <ContentTemplate>
<div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) { return; }
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/en_US/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));</script>

<div class="fb-like-box" data-href="http://www.facebook.com/pages/MySis-Technologies/131116233651019" data-width="180" data-show-faces="true" data-border-color="White" data-stream="false" data-header="false"></div>
</ContentTemplate>
</mysis:Block>


