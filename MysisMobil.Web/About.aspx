<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/AboutSidebar1.ascx" %>


<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Hakkýnda | MySisMobil Araç Takip Sistemleri
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

<mysis:Article ID="Article1"  runat="server" Caption="Hakkýnda">
    <ContentTemplate>
    <div style="position:absolute; zoom: 1; margin:30px;
        filter: alpha(opacity=5); opacity: 0.05;">
        <img src="images/mysis1.png" />
    </div>
    <link rel="stylesheet" type="text/css" href="css/table.css" />
      <div id="container">
   
        <div id="table">
        
        <ul>
         <li class="clearfix">
            
            <div>
            
            <h3></h3>
            <p>MYSÝS A.Þ (Merkezi Yönetim Sistemleri ), mobil teknolojiler üretmek amacýyla 2000 yýlýnda kurulmuþ bir teknoloji þirketidir.</p>
<p>Atatürk’ün iþaret ettiði muasýr medeniyet seviyesine ulaþma hedefi doðrultusunda vizyonumuz;  </p>

<p>Bu günün ve geleceðin en büyük ve en özellikli faaliyet alaný olan teknoloji alanýnda baþta Yazýlým,Enerji ve Haberleþme olmak üzere sektöründe lider olmak, bilim ve teknolojiye hakim, teknolojiyi bilinçli kullanan ve yeni teknolojiler üretebilen, teknolojik geliþmeleri toplumsal ve ekonomik faydaya dönüþtürme yeteneði kazanmýþ þirket profili sergilemek,  araþtýrma ve geliþtirme aðýrlýklý çalýþarak özgün tasarým ile dýþa baðýmlýlýðý azaltmak, örgüt personeli tarafýndan tasarlanýp ortaya koyulmuþ ileri teknoloji ürünleri sektöre sunmak ve bu kapsamda tüm dünyaya hizmet verebilecek güvenilir, ihtiyaç olan her yerde hazýr bulunabilen, iç ve dýþ pazarlarda söz sahibi bir iþletme yaratmaktýr.</p>
<p>Bu vizyon çerçevesinde müþteri memnuniyetini her zaman kendisine hedef edinen MYSÝS A.Þ, bundan sonraki faaliyet hayatýnda da edinmiþ olduðu güvenilir ve istikrarlý yapýsýndan taviz vermeden kalýcý hizmetler vermeye devam edecektir.</p>
            </div>
         </li>
         
        </ul>
    </div>
</div>

    </ContentTemplate>
</mysis:Article>
</asp:Content>


