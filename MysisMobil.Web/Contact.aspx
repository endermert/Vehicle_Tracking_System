<%@ Page Language="C#" MasterPageFile="~/design/MasterPage.master" ValidateRequest="false" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="_Default" Title="Untitled Page" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>
<%@ Register TagPrefix="art" TagName="DefaultMenu" Src="DefaultMenu.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultHeader" Src="DefaultHeader.ascx" %> 
<%@ Register TagPrefix="art" TagName="DefaultSidebar1" Src="~/AboutSidebar1.ascx" %>
<%@ Register assembly="ComponentArt.Web.UI" namespace="ComponentArt.Web.UI" tagprefix="ComponentArt" %>          

<asp:Content ID="PageTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    Ýletiþim | MySisMobil Araç Takip Sistemleri
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
    <div style="position:absolute; width:auto">
<mysis:Article ID="Article1" runat="server" Width="685">
    <ContentTemplate>
        <asp:Panel ID="Panel" runat="server" Height="530"></asp:Panel>
    </ContentTemplate>
</mysis:Article>
</div>

<div style="position:absolute; width:auto; height:550px; margin:5px; padding:5px;"  >
<link rel="stylesheet" href="osstyle.css" type="text/css">

<asp:Panel ID="Panel1" runat="server" Width="670" Height="550">

<h3><img alt="" src="./images/ico/mail_forward.png">Bizimle Ýletiþime Geçin..</h3>
<span class="desc">Mesaj býrakýn, biz sizi arayalým.. </span>
<hr class="double-standards clear" />

<div id="stylized" class="myform">
 <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Ýsim"></asp:Label>
                         <asp:RequiredFieldValidator 
                            runat="server"
                            ControlToValidate="tIsim"
                            CssClass="validator_message"
                            ErrorMessage="Ýsim alaný gereklidir.."
                          />
                    </td>
                
                </tr>
                <tr>
                    <td>
                       <div class="fieldc" style="padding-top:0px; float:left;">
                          <ComponentArt:MaskedInput runat="server"
                            ID="tIsim"
                            Text=""
                            MaxLength="50"
                            CssClass="valid"
                            EmptyCssClass="empty"
                            FocusedValidCssClass="focused-valid"
                            FocusedCssClass="focused"
                            InvalidCssClass="invalid"
                            DisabledCssClass="disabled"
                            Transform="empty"
                          />
                         
                        </div>
                    </td>
                  
                </tr>
                   <tr>
                    <td>
                        <asp:Label runat="server" Text="Email"></asp:Label>
                        <asp:RequiredFieldValidator
                            runat="server"
                            ControlToValidate="tEmail"
                            CssClass="validator_message"
                            ErrorMessage="E-mail alaný gereklidir.. "
                          />
                           
                    </td>
              
                </tr>
                <tr>
                    <td>
                         <div class="fieldc" style="padding-top:0px; float:left;">
                          <ComponentArt:MaskedInput runat="server"
                            ID="tEmail"
                            Text=""
                            MaxLength="50"
                            CssClass="valid"
                            EmptyCssClass="empty"
                            FocusedValidCssClass="focused-valid"
                            FocusedCssClass="focused"
                            InvalidCssClass="invalid"
                            DisabledCssClass="disabled"
                            Transform="EmailAddress"
                          />
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="tEmail"
                            CssClass="validator_message"
                            ErrorMessage="<br/>E-mail bilgisi yanlýþ."
                            ValidationExpression="^((?:(?:(?:[a-zA-Z0-9][\.\-\+_]?)*)[a-zA-Z0-9])+)\@((?:(?:(?:[a-zA-Z0-9][\.\-_]?){0,62})[a-zA-Z0-9])+)\.([a-zA-Z0-9]{2,6})$"
                          />
                        </div>
                    </td>
        
                </tr>
                   <tr>
                    <td>
                        <asp:Label runat="server" Text="Mesaj"></asp:Label>
                         <asp:RequiredFieldValidator
                            runat="server"
                            ControlToValidate="tMesaj"
                            CssClass="validator_message"
                            ErrorMessage="Mesaj alaný gereklidir.."
                          />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="tMesaj" runat="server" MaxLength="255" Height="100px" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnGonder" runat="server" Text="Gönder" 
            onclick="btnGonder_Click" />
        <hr class="double-standards clear" />
        <asp:Label ID="cvpLabel" runat="server" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList" 
            HeaderText="Lütfen bu alanlarý kontrol edin:" />
             
</div>
       

 <div id="gmap">

         <div id="giframe">
         <!-- Google maps: Generate yours from http://maps.google.com/help/maps/getmaps/quick.html#one-location  -->
         <!-- Dimensions for the IFRAME width:540 height:315 -->
          <!--<iframe width="350" height="315" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=en&amp;geocode=&amp;q=eiffel+tower+,+paris&amp;sll=37.0625,-95.677068&amp;sspn=53.961216,135.263672&amp;ie=UTF8&amp;hq=eifel+tower+,&amp;hnear=Paris,+%C3%8Ele-de-France,+France&amp;t=h&amp;cid=16368737961990282081&amp;ll=48.858059,2.293986&amp;spn=0.001906,0.005729&amp;z=17&amp;iwloc=A&amp;output=embed"></iframe>-->
          <iframe width="350" height="315" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="http://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=tr&amp;geocode=&amp;q=40.740494,30.387551&amp;aq=&amp;sll=35.817813,-95.712891&amp;sspn=42.860844,79.013672&amp;vpsrc=0&amp;ie=UTF8&amp;t=h&amp;ll=40.740949,30.387583&amp;spn=0.020485,0.029955&amp;z=14&amp;output=embed"></iframe>
          <br /><small><a href="http://maps.google.com/maps?f=q&amp;source=embed&amp;hl=tr&amp;geocode=&amp;q=40.740494,30.387551&amp;aq=&amp;sll=35.817813,-95.712891&amp;sspn=42.860844,79.013672&amp;vpsrc=0&amp;ie=UTF8&amp;t=h&amp;ll=40.740949,30.387583&amp;spn=0.020485,0.029955&amp;z=14" style="color:#0000FF;text-align:left">Daha Büyük Görüntüle</a></small>
         </div><!-- giframe -->
 
         <div id="contact-info">
          <p><strong>Erturulgazi cad. Yeþiltepe Mah.</strong></p>
          <p><strong>Sakarya,Türkiye,TR</strong></p>
          <p><br /><strong>Tel: 0 (264) 341-0130  <br />
           Email: info@mysismobil.com</strong></p>
         </div><!-- /contact-info -->
 
         <div class="clear"></div>
         </div>
         <!-- /gmap -->
        </asp:Panel>
        </div>
        <div style="width:5px; height:565px;" ></div>
</asp:Content>

