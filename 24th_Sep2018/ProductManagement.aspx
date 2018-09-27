<%@ Page Language="C#" ViewStateMode="Disabled" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="_24th_Sep2018.ProductManagement" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="auto-style1">
            <div class="text-center" style="font-family: Arial; font-size: x-large">
            Product Management</div>
            <div class="text-center" style="text-align: center">
                <span style="font-family: Arial; font-size: x-large">&nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Insert1.aspx">Insert</asp:HyperLink>
                </span>
                <br />
                <br />
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </asp:Content>