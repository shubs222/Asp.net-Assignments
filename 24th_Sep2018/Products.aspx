<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="_24th_Sep2018.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="height: 38px" class="text-center">Products</h2>
    <h3>&nbsp;</h3>
    <p style="height: 34px" class="text-center">Search here:
        <asp:TextBox ID="SearchBox" runat="server" Height="19px" Width="276px"></asp:TextBox>
        <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" style="position: relative; left: 6px; top: 0px; width: 79px; height: 27px" Text="Search" />
    </p>
   <div style="height: 493px; position: relative; left: -44px; top: 10px; margin-left: 40px; width: 905px;" class="text-center">
       


      <%-- <p><img src="Content/Headset.jpg" /></p>--%>
      <%-- <img src="Content/Shoes.jpg" /><img src="Content/Watch.png" />--%>
      
       <asp:PlaceHolder ID="PlaceHolder1" runat="server">


       </asp:PlaceHolder>
     
    
     
       
    
   </div>

</asp:Content>
