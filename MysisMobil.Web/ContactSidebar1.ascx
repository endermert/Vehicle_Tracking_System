<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ContactSidebar1.ascx.cs" Inherits="Sidebar1" %>
<%@ Import Namespace="MySis" %>
<%@ Register TagPrefix="mysis" Namespace="MySis" %>

<mysis:Block ID="ContactInformationBlock" Caption="Mysis Ýletiþim" runat="server"><ContentTemplate><div>
                <img src="images/company.jpg" alt="an image" style="margin: 0 auto;display:block;width:95%" />
          <br />
          <b>Mysis Mobil Technologies</b><br />
          <br />
          E-Posta: <a href="mailto:info@mysis.org">info@mysis.org</a><br />
          <br />
          Telefon: (123) 456-7890 <br />
          Fax: (123) 456-7890
          </div>
             </ContentTemplate>
</mysis:Block>

