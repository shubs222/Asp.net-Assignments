<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Update.aspx.cs" Inherits="_24th_Sep2018.Update" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
           <center> <h1 class="auto-style1">Update Data</h1>
        </div>
        <div class="auto-style2">

            <div class="text-center">
                <div class="text-center" style="height: 161px">
                ProductName:
                <asp:TextBox ID="ProductName" runat="server"></asp:TextBox>
                <br />
                <br />
                Price:
                <asp:TextBox ID="ProductPrice" runat="server"></asp:TextBox>
                <br />
                <br />
                Description:
                <asp:TextBox ID="ProductDescriprtion" runat="server"></asp:TextBox>
                <br />
                <br />
                Image Url:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </div>
                <asp:FileUpload ID="ImageUpload" runat="server" style="position: relative; left: 386px; top: 0px; width: 180px" />
                <div class="text-center" style="height: 63px">
                <br />
                <br />
                Brand:
                <asp:DropDownList ID="BrandName" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id">
                </asp:DropDownList>
                </div>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AcuDataConnectionString2 %>" SelectCommand="SELECT [Id], [Name] FROM [Brand]"></asp:SqlDataSource>
            <div class="text-center" style="text-align: center">
                <br />
                <asp:Button ID="UpdateButton" runat="server" Height="35px" OnClick="UpdateButton_Click" Text="Update" Width="103px" />
                <br />
            </div>

        </div>
        </center>
</asp:Content>