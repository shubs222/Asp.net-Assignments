<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="_24th_Sep2018.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="height: 38px"><%: Title %>.</h2>
    <h3>Products</h3>
    <p style="height: 34px" class="text-center">Search here:
        <asp:TextBox ID="TextBox1" runat="server" Height="19px" Width="276px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="position: relative; left: 6px; top: 0px; width: 79px; height: 27px" Text="Search" />
    </p>
   <div style="height: 493px; position: relative; left: -44px; top: 10px; margin-left: 40px; width: 905px;" class="text-center">
       


      <%-- <p><img src="Content/Headset.jpg" /></p>--%>
      <%-- <img src="Content/Shoes.jpg" /><img src="Content/Watch.png" />--%>
      
       <asp:PlaceHolder ID="PlaceHolder1" runat="server">


       </asp:PlaceHolder>
     
    
     
       
    
       <asp:GridView ID="GridView1" runat="server">
       </asp:GridView>
     
    
     
       
    
   </div>

</asp:Content>
