<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AboutSidebar1.ascx.cs" Inherits="Sidebar1" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>

<mysis:Block ID="DemoBlock" Caption="Resim" runat="server">
<ContentTemplate><div class="imageholder"><img src="images/pozitif1.jpg" alt="Images" /></div>
    </ContentTemplate>
</mysis:Block>
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