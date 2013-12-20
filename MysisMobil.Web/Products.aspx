<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/DefaultSidebar1.ascx" %>


<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Ürünler | MySisMobil Araç Takip Sistemleri
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

<mysis:Article ID="Article1"  runat="server">
    <ContentTemplate>
        
<link rel="stylesheet" type="text/css" href="css/table.css" />
<script type="text/javascript" src="js/jquery-1.4.4.min.js" ></script>
<script type="text/javascript" src="js/cufon-yui.js"></script>
<script type="text/javascript" src="js/Colaborate-Regular_400-Colaborate-Bold_400.font.js"></script>
<script type="text/javascript" src="js/jquery.vPricingTables.js" ></script>
<script type="text/javascript">
    $(function () {

        $("#table").vPricingTables();

    });
</script>
        <div id="container">
   
        <div id="table">
        
        <ul>
         <li class="clearfix">
            <div>
            <h3>Mysis Mobil Web Software</h3>
            <p>Locator' dan aldýðý datalarý iþleyerek bu sistemi kullananlara konum ve diðer deðiþken belirtimlerini saðlar. Bu sistem Web ve Masaüstü uygulamasý gibi kullanýlabilir.</p>
            </div>
            <div class="imageholder"><img src="images/map.png" alt="Images" /></div>
         </li>
        <li class="clearfix">
            <div class="imageholder"><img src="images/modem.png" alt="Images" /></div>
            <div>
            <h3>Mysis Mobil Locator</h3>
            <p>Dünyada üzerindeki 24 uydudan oluþan aðý kullanarak bizim istediðimiz nokta üzerindeki konumun bize bildirmesini saðlayan GPS modemimizdir.</p>
            </div>
         </li>  
        
         
        </ul>
        
        <div class="vlists">
        
            
            <ul>
                <!--<li><a href="#">Detaylar</a></li>-->
                <li><a href="#">Software</a></li>
                <!--<li><h2>Software</h2></li>-->
                <li>Web & Masaüstü</li>
                <li>Sayýsal Haritalar</li>
                <li>Anlýk Araç Takibi</li>
                <li>Esnek Raporlama</li>
                <li>7/24 Kesintihiz Hizmet</li>
            </ul>
           
             <ul>
                <!--<li><a href="#">Deyatlar</a></li>-->
                <li><a href="#">Hardware</a></li>
                <!--<li><h2>Locator</h2></li>-->
                <li>50 Kanal GPS</li>
                <li>GSM</li>
                <li>GPRS</li>
                <li>3 input</li>
                <li>6 output</li>
                
            </ul>
        </div>
        
        
      
    </div>



</div>
    </ContentTemplate>
</mysis:Article>
</asp:Content>


