<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Delete.aspx.cs" Inherits="_24th_Sep2018.Delete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="auto-style1">
                <div class="text-center">
                    <br />
                    <br />
                Product Name:&nbsp;
                <asp:TextBox ID="ProductName" runat="server"></asp:TextBox>
                <br />
                <br />
                Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ProductPrice" runat="server"></asp:TextBox>
                <br />
                <br />
                Description:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="ProductDescription" runat="server"></asp:TextBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                    <asp:Image ID="ProductimageUrl" runat="server" Height="162px" Width="224px" />
                    <br />
                <br />
                <br />
                Select Brand:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="BrandList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id" Height="39px" Width="140px">
                </asp:DropDownList>
                </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AcuDataConnectionString3 %>" SelectCommand="SELECT [Id], [Name] FROM [Brand]"></asp:SqlDataSource>
                <div class="text-center" style="text-align: center">
                <br />
                <br />
                <br />
                <asp:Button ID="DeleteProduct" runat="server" CssClass="auto-style3" OnClick="DeleteProduct_Click" Text="Delete Product" />
                </div>
        </div>
</asp:Content>