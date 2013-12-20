<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DefaultHeader.ascx.cs" Inherits="DefaultHeader" %>
<script type="text/javascript" src="swfobject.js"></script>
<div id="art-flash-area">
<div id="art-flash-container">
<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000" width="1000" height="250" id="art-flash-object">
    <param name="movie" value="images/flash.swf" />
    <param name="quality" value="high" />
	<param name="scale" value="exactfit" />
	<param name="wmode" value="transparent" />
	<param name="flashvars" value="color1=0xFFFFFF&amp;alpha1=.30&amp;framerate1=24&amp;loop=true&amp;wmode=transparent" />
    <param name="swfliveconnect" value="true" />
    <!--[if !IE]>-->
    <object type="application/x-shockwave-flash" data="images/flash.swf" width="1000" height="250">
        <param name="quality" value="high" />
	    <param name="scale" value="exactfit" />
	    <param name="wmode" value="transparent" />
	    <param name="flashvars" value="color1=0xFFFFFF&amp;alpha1=.30&amp;framerate1=24&amp;loop=true&amp;wmode=transparent" />
        <param name="swfliveconnect" value="true" />
    <!--<![endif]-->
      	<div class="art-flash-alt"><a href="http://www.adobe.com/go/getflashplayer"><img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif" alt="Get Adobe Flash player" /></a></div>
    <!--[if !IE]>-->
    </object>
    <!--<![endif]-->
</object>
</div>
</div>
<script type="text/javascript">swfobject.switchOffAutoHideShow();swfobject.registerObject("art-flash-object", "9.0.0", "expressInstall.swf");</script>
<div style="position:absolute; top:10px; left:10px;">
    <iframe src="http://www.facebook.com/plugins/like.php?href=http://www.mysismobil.com/"
        scrolling="no" frameborder="0" allowtransparency="true"
        style="border:none; width:450px; height:80px"></iframe>
</div>