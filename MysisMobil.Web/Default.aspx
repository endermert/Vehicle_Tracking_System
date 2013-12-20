<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="DefaultSidebar1.ascx" %>
          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Anasayfa | MySisMobil Araç Takip Sistemleri
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

<div class="art-post" style=""  >
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
<h2 class="art-postheader"></h2>
<div class="art-postcontent">


    <link rel="stylesheet" href="osstyle.css" type="text/css">

  <div id="content">
   <div class="container1">
   
   <div id="usp">
   <iframe title="YouTube video player" class="youtube-player" type="text/html"  
width="300" height="200" src="http://www.youtube.com/embed/_Dhwe09OGlE?fs=1&autoplay=1&loop=2" 
frameborder="0" allowFullScreen></iframe>

<!--    <div id="social">
    <a href="http://twitter.com/share" class="twitter-share-button" data-count="horizontal">Tweet</a><script type="text/javascript" src="http://platform.twitter.com/widgets.js"></script>
    <iframe src="http://www.facebook.com/plugins/like.php?app_id=228252540549489&amp;send=false&amp;layout=button_count&amp;width=100&amp;show_faces=false&amp;action=like&amp;colorscheme=light&amp;font&amp;height=21" scrolling="no" frameborder="0" style="border:none; overflow:hidden; width:100px; height:21px;" allowTransparency="true"></iframe>
    </div>-->
	   

   </div> <!-- /#usp -->
   
   <h3 class="title"><span>Araç Takip Sistemleri </span></h3>
   <p>
    Araç takip sistemi, araca takýlan bir terminal ve GPS anteni sayesinde araçtan alýnan bilgilerin, GPRS aðý kullanýlarak bilgisayarýnýza aktarýlmasýný saðlar. Bilgisayarýnýza aktarýlan bu bilgiler harita üzerinde gösterilir.
    <br />
    Araç takip, þirketlere ve kullanýcýlarýna birçok yönden avantajlar sunar. 
    </p>
    <br />

   <hr class="double-standards" />
<div class="box" id="boxOne">
 <h3><img alt='' src="./images/ico/clipboard_check.png">Faydalarý</h3>
 <span class="desc" style="margin-left:20px;">Teknoloji sizin için var!</span>

    <ul class="tick"><li><a href="#">Konum ve Hýz Bilgisi</a></li></ul>
    <p>Mysismobil Araç Takip Sistemi ile þirketler ve kurumlar, araçlarýnýn nerede olduðunu hangi hýzda gittiði
görebildiði gibi ,</p>
    <ul class="tick"><li><a href="#">Güzergah-Zaman Tanýmý</a></li></ul>
    <p>Tanýmlanan güzergaha, verilen programda yer-zaman planýna uyulup uyulmadýðýný görebilirler.</p>
    <ul class="tick"><li><a href="#">Sorumlu Davranýþ ve Otokontrol</a></li></ul>
    <p>Araç kullanýcýlarý ise; daha fazla sorumluluk hissederler ve gidecekleri yere zamanýnda giderler, gereksiz molalardan kaçýnýrlar, </p>
    <ul class="tick"><li><a href="#">Minimum Kaza Riski</a></li></ul>
    <p>Aþýrý hýz yapmazlar ve bu sayede kaza riski en aza iner, </p>
    <ul class="tick"><li><a href="#">Yakýt Tasarrufu</a></li></ul>
    <p>Yakýt tüketimi azalýr.</p>
    
    
   
</div>
<div class="box">
 <h3><img alt='' src="./images/ico/clipboard_add.png">Temel Özellikler</h3>
 <span class="desc" style="margin-left:20px;">Profesyonel Yaklaþýmlar</span>

    <ul class="tick">
        <li><a href="#">En Uygun Fiyat</a></li>
        <li><a href="#">Anlýk Araç Takibi</a></li>
        <li><a href="#">Geçmiþi Ýzleme</a></li>
        <li><a href="#">Hýz, Mesafe ve Kontak Bilgileri</a></li>
        <li><a href="#">Duraklama ve Rölanti Kontrolü</a></li>
        <li><a href="#">Esnek Raporlama</a></li>
    </ul>
    <p>
        Firmalarda araçlarýnýn nerede, hangi konumda, duraðan mý, ilerleyen mi, ne kadar 
        sürat yapmakda gibi bilgileri isteme arzusu bulunur ve bu çok önemlidir.</p>
   
</div>

   </div><!-- /.container1 -->
  </div><!-- /#content -->
  

</div>
<div class="cleared"></div>

</div>

		<div class="cleared"></div>
    </div>
</div>
</asp:Content>
