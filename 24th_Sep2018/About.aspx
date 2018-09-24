<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="_24th_Sep2018.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="height: 38px"><%: Title %>.</h2>
    <h3>Products</h3>
    <p style="height: 22px">Use this area to provide additional information.</p>
   <div style="height: 166px">
       


      <%-- <p><img src="Content/Headset.jpg" /></p>--%>
      <%-- <img src="Content/Shoes.jpg" /><img src="Content/Watch.png" />--%>
      
       <asp:PlaceHolder ID="PlaceHolder1" runat="server">


       </asp:PlaceHolder>
     
    
     
       
    
   </div>

</asp:Content>
