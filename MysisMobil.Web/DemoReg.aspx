<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="DemoReg.aspx.cs" Inherits="DemoReg" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/DefaultSidebar1.ascx" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register assembly="ComponentArt.Web.UI" namespace="ComponentArt.Web.UI" tagprefix="ComponentArt" %>

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Demo | MySisMobil Araç Takip Sistemleri</asp:Content>

<asp:Content ID="MenuContent" ContentPlaceHolderID="MenuContentPlaceHolder" Runat="Server">
    <art:DefaultMenu ID="DefaultMenuContent" runat="server" />
</asp:Content>
<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeaderContentPlaceHolder" Runat="Server">
    <art:DefaultHeader ID="DefaultHeader" runat="server" />
</asp:Content>
<asp:Content ID="SideBar1" ContentPlaceHolderID="Sidebar1ContentPlaceHolder" Runat="Server">
    <art:DefaultSidebar1 ID="DefaultSidebar1Content" runat="server" />
</asp:Content>

<asp:Content ID="SheetContent" ContentPlaceHolderID="SheetContentPlaceHolder" Runat="Server">

<telerik:RadScriptManager ID="ScriptManager" runat="server" />
<div class="art-post">
 <div class="art-post-tl"></div>
<div class="art-post-tr"></div>
<div class="art-post-bl"></div>
<div class="art-post-br"></div>
<div class="art-post-tc"></div>
<div class="art-post-bc"></div>
<div class="art-post-cl"></div>
<div class="art-post-cr"></div>
<div class="art-post-cc"></div>
<div class="art-post-body">
<div class="art-post-inner">
<h2 class="art-postheader">Bir Günlük Demo Þifrenizi Alýn..</h2>
<div class="art-postcontent"><!--icerik-->

<div style="margin:20px; width:auto;">

    <div class="field" style="padding-top:0px;">
      <span class="lbl">Ad Soyad:</span>
      <componentart:maskedinput runat="server"
        ID="tYetkili"
        Text=""
        EmptyText="Yetkili Adý Soyadý"
        MaxLength="100"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
      />
    </div>

    <div class="field">
      <span class="lbl">GSM:</span>
      <componentart:maskedinput runat="server"
        ID="tGsm"
        Text=""
        AcceptedCharacters="1234567890- ()"
        EmptyText="(000) 000-0000"
        MaxLength="10"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        Transform="Telephone_NorthAmerica"
      />
      <asp:RequiredFieldValidator
        runat="server"
        ControlToValidate="tGsm"
        CssClass="validator_message"
        ErrorMessage="GSM alaný gereklidir.. "
        ValidationGroup="group1"
        />

    </div>
    <div class="fieldk" style="padding-top:0px;height:auto;">
      <span class="lbl">Güvenlik Kodu:</span>
      <div style="width:470px; height:auto; float:right;">
        <telerik:RadCaptcha ID="RadCaptcha1" Runat="server" CaptchaTextBoxLabel="Resimdeki Yazý" 
        ErrorMessage="Güvenlik Kodu Yanlýþ.." ValidationGroup="group1"/>
      </div>
    </div>
       

    <div style="float:right; margin-right:250px;" >
        <asp:Button class="art-button" ID="btnGonder" runat="server"  ValidationGroup="group1"
        Text="Þifremi SMS Ýle Gönder" onclick="bntDemoSmsGonder_Click"  />
        
    </div>
    <div style="float:right; margin-right:250px;" >
        <asp:label ID="cvpLabel" runat="server" ></asp:label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList" 
        HeaderText="Lütfen bu alanlarý kontrol edin:" ValidationGroup="group1" />
    </div>

     
    
</div><!--icerik-->

<div class="cleared"></div></div>

		<div class="cleared"></div>
    </div>
</div></div>
</asp:Content>


