<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind ="ProductDetail.aspx.cs" Inherits="_24th_Sep2018.ProductDetail" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Product Details</h1>
        <div class="text-center" style="height: 506px">

            <em>&nbsp;<asp:Label ID="ProductName" runat="server" style="font-family: Arial; font-size: x-large" Text="Label"></asp:Label>
            <br />
&nbsp;
            <asp:Image ID="ProductImage" runat="server" Height="282px" Width="193px" />
            <br />
            <br />
            <asp:Label ID="ProductPrice" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="ProductDesription" runat="server" Text="Label"></asp:Label>
            </em>

        </div>
    </div>
        </asp:Content>
