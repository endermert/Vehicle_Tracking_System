<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Dealers.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/DefaultSidebar1.ascx" %>



<%@ Register assembly="ComponentArt.Web.UI" namespace="ComponentArt.Web.UI" tagprefix="ComponentArt" %>



<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Bayilik | MySisMobil Araç Takip Sistemleri
</asp:Content>

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
<h2 class="art-postheader"> Bayi Baþvuru Formu</h2>
<div class="art-postcontent">

 <div style="margin:20px; width:auto;">
        <div class="field" style="padding-top:0px;">
          <span class="lbl">Baþvurulan Ýl:</span>
          <ComponentArt:MaskedInput runat="server"
            ID="til"
            Text=""
            EmptyText="Ýli Giriniz"
            MaxLength="100"
            CssClass="valid"
            EmptyCssClass="empty"
            FocusedValidCssClass="focused-valid"
            FocusedCssClass="focused"
            InvalidCssClass="invalid"
            DisabledCssClass="disabled"
        
          />
       </div>

    <div class="field" style="padding-top:0px;">
      <span class="lbl">Baþvurulan Ýlçe:</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tilce"
        Text=""
        EmptyText="Ýlçeyi Giriniz"
        MaxLength="100"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        
      />
    </div>

    <div class="field" style="padding-top:0px;">
      <span class="lbl">Ticari Ünvan:</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tUnvan"
        Text=""
        EmptyText="Ticari Ünvaný Giriniz"
        MaxLength="100"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        
      />
    </div>

    <div class="field" style="padding-top:0px;">
      <span class="lbl">Yetkili Adý Soyadý:</span>
      <ComponentArt:MaskedInput runat="server"
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

    <div class="field" style="padding-top:0px;">
      <span class="lbl">Adres :</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tAdres"
        Text=""
        EmptyText="Adresi Giriniz"
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
      <span class="lbl">Telefon:</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tTel"
        Text=""
        AcceptedCharacters="1234567890- ()"
        EmptyText="(000) 000-0000"
        MaxLength="20"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        Transform="Telephone_NorthAmerica"
      />
    </div>

    <div class="field">
      <span class="lbl">Fax:</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tFax"
        Text=""
        AcceptedCharacters="1234567890- ()"
        EmptyText="(000) 000-0000"
        MaxLength="20"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        Transform="Telephone_NorthAmerica"
      />
    </div>

    <div class="field">
      <span class="lbl">GSM:</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tGsm"
        Text=""
        AcceptedCharacters="1234567890- ()"
        EmptyText="(000) 000-0000"
        MaxLength="20"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        Transform="Telephone_NorthAmerica"
      />
    </div>

    <div class="field">
      <span class="lbl">Email:</span>
      <ComponentArt:MaskedInput runat="server"
        ID="tEmail"
        Text=""
        EmptyText="name@domain.com"
        CssClass="valid"
        EmptyCssClass="empty"
        FocusedValidCssClass="focused-valid"
        FocusedCssClass="focused"
        InvalidCssClass="invalid"
        DisabledCssClass="disabled"
        Transform="EmailAddress"
      />
    </div> 
    <div style="float:right; margin-right:80px;" >
    <asp:Button class="art-button" ID="btnGonder" runat="server"  Text="Gönder" 
            onclick="btnGonder_Click" />
    <asp:label ID="cvpLabel" runat="server" ></asp:label>
    </div>
</div>

</div>
<div class="cleared"></div>

</div>

		<div class="cleared"></div>
    </div>
</div>

</asp:Content>


