<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Solutions.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/DefaultSidebar1.ascx" %>


<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Çözümler | MySisMobil Araç Takip Sistemleri
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

<mysis:Article ID="Article1"  runat="server" Caption="Çözümler">
    <ContentTemplate>

<style type="text/css">



.con {
	width:650px;
	margin: 0 auto;
	float:left;
}


h2.acc_trigger {
	padding: 0;	margin: 0 0 5px 0;
	background: url(images/h2_a.png) no-repeat;
	height: 46px;	line-height: 46px;
	width: 650px;
	float: left;
}
h2.acc_trigger a {
	text-decoration: none;
	display: block;
	padding: 0 0 0 50px;
	font-size:small;
}

h2.active {background-position: left bottom;}

.acc_con {
	margin: 0 0 5px; padding: 0;
	overflow: hidden;
	font-size: 1.2em;
	width: 650px;
	clear: both;
	background: #f0f0f0;
	border: 1px solid #d6d6d6;
	-webkit-border-bottom-right-radius: 5px;
	-webkit-border-bottom-left-radius: 5px;
	-moz-border-radius-bottomright: 5px;
	-moz-border-radius-bottomleft: 5px;
	border-bottom-right-radius: 5px;
	border-bottom-left-radius: 5px; 
}
.acc_con .block {
	padding: 20px;
}
.acc_con .block p {
	padding: 5px 0;
	margin: 5px 0;
}

.acc_con img {
	float: left;
	margin: 10px 15px 15px 0;
	padding: 5px;
	background: #ddd;
	border: 1px solid #ccc;
}
</style>
<script type="text/javascript">
    $(document).ready(function () {

        //Set default open/close settings
        $('.acc_con').hide(); //Hide/close all cons
        // $('.acc_trigger:first').addClass('active').next().show(); //Add "active" class to first trigger, then show/open the immediate next con

        //On Click
        $('.acc_trigger').click(function () {
            if ($(this).next().is(':hidden')) { //If immediate next con is closed...
                $('.acc_trigger').removeClass('active').next().slideUp(); //Remove all .acc_trigger classes and slide up the immediate next con
                $(this).toggleClass('active').next().slideDown(); //Add .acc_trigger class to clicked trigger and slide down the immediate next con
            } else {
                $(this).toggleClass('active').next().slideUp();
            }
            return false; //Prevent the browser jump to the link anchor
        });

    });
</script>
</head>


<div class="con">

	<h2 class="acc_trigger"><a href="#"> Eþsiz Sanayi Deneyimi</a></h2>
	<div class="acc_con">
		<div class="block">
            <a href="#"><img src="images/solution1.jpg" alt="" /></a>
			<p>Mysis Teknolojileri birçok alanda, sanayiyi anlayan, rekabet eden, endüstri trendlerini ve teknolojik geliþmeleri takip ederek bu piyasalarýn deðiþen gereksinimlerinin farkýnda olan, bu bilgi derinliðinde müþterilerine güven ve gelecekte karþý karþýya kalacaklarý sorunlarda dahi yardýmcý olabilen bir teknoloji þirketidir. Mysis Teknolojileri ulaþým, hükümet, hizmet, sigorta gibi sektörleri mobil varlýklarýný akýllý ve daha verimli yönetmek için çözümler sunar.</p>
		</div>
	</div>
	<h2 class="acc_trigger"><a href="#">Taþýmacýlýk</a></h2>
	<div class="acc_con">
		<div class="block">
			<h3></h3>
            <a href="#"><img src="images/solution2.jpg" alt="" /></a>
			<p>Mysis, taþýma þirketlerinin geliþmiþ operasyonel verimlilik, üstün müþteri hizmeti ve gelir artýþý ile pazarda yer kaplanmasý geniþlemesi için tam ve esnek araç takip çözümü saðlar. Faturalanabilir kilometreyi arttýrmak, yakýt ve bakým maliyetlerinde tasarruf, güvenlik ve verimliliði artýrmak, otomatik sürücü günlük bilgileri, kapsamlý araç teþhis ve izleme seçenekleri, tam telemetri raporlarý ile yolda ve ofiste yeni verimlilik elde etmek için gereken tüm araçlar bulunmaktadýr.</p>
            
		</div>
	</div>
    <h2 class="acc_trigger"><a href="#">Hükümet</a></h2>
	<div class="acc_con">
		<div class="block">
			<h3></h3>
            <a href="#"><img src="images/solution3.jpg" alt="" /></a>
			<p>Mysis, Hükümet için tam bir GPS / AVL çözümü sunmaktadýr. Canlý ekranlar, haritalar, uzaktan araç teþhis, proaktif bakým programlarý, makine arayüzü, geniþ bir yelpazede destek ve geniþ bir dizi  entegrasyonlar ile, filo operatörleri, tüm mobil varlýklarýn yerini ve durumunu izleyebilirsiniz. Þimdi kombine donaným ve yazýlým ile endüstrinin en kararlý ve eksiksiz  GPS / AVL çözümünü keþfedebilirsiniz. </p>
		</div>
	</div>
    <h2 class="acc_trigger"><a href="#">Hizmet</a></h2>
	<div class="acc_con">
		<div class="block">
			<h3></h3>
            <a href="#"><img src="images/solution4.jpg" alt="" /></a>
			<p>Bizim çözümlerimiz çeþitli boyutlarda hizmet þirketleri tarafýndan seçilmiþ ve uygulanmýþtýr. Özellikle geniþ bir geofence seti, kabin içi iletiþim ve araç teþhis içerir. Sürekli deðiþen programlar ile iþgücü verimliliði artýrýlýr, güvenlik optimize edilir ve bilgi paylaþýmý geliþtirilir.</p>
		</div>
	</div>
	<h2 class="acc_trigger"><a href="#">Sistem Nasýl Çalýþýyor ?</a></h2>
	<div class="acc_con">
		<div class="block">
			<h3></h3>
            <a href="#"><img src="images/solution5.png" alt="" /></a>
			<p>Mysis Mobil araç takip cihazý içerisine GSM data hattý konularak þirket araçlarýna monte edilir. Cihaz GPS uydularýndan almýþ olduðu konum ve diðer araç bilgilerini GSM/GPRS kanalý üzerinden Mysis sunucularýna aktarýr. Bu bilgiler özel yazýlýmlar sayesinde okunabilinir formata çevrilir ve müþterilerin hizmetine anlýk ve geçmiþe yönelik bilgiler halinde sunulur. Bilgiler Mysis sunucularýnda barýndýrýldýðý için herhangi bir aksama ya da veri kaybý olmaz. </p>
		</div>
	</div>
	
	<h2 class="acc_trigger"><a href="#">Yatýrýmýn Geri Dönüþü</a></h2>
	<div class="acc_con">
		<div class="block">
        <a href="#"><img src="images/solution6.jpg" alt="" /></a>
        <p>Mobil çözümler filo yöneticileri, memurlarý ve üst düzey yönetimi için gerçek zamanlý araç bilgilerini saðlar.Mobil çözümümüz sizin filo operasyonlarýnýzýn tüm yönleri içine geliþtirilmiþ verimlilik, yüksek müþteri memnuniyeti, ve yönetim görünürlüðü de dahil olmak üzere muazzam bir organizasyon faydalar saðlayabilir.</p>
		</div>
	</div>
	
</div>
    </ContentTemplate>
</mysis:Article>
</asp:Content>


