<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Insert1.aspx.cs" Inherits="_24th_Sep2018.Insert1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


  
        <div class="auto-style1">
            <h1 class="auto-style2" style="text-align: center">Insert</h1>

            <br />
            <table class="auto-style3" align="center">
                <tr>
                    <td class="auto-style4">Product Name:&nbsp; </td>
                    <td class="auto-style5">&nbsp;&nbsp;
                        <asp:TextBox ID="ProductName" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="Name" runat="server" ControlToValidate="ProductName" EnableViewState="False" ErrorMessage="Provide Name"></asp:RequiredFieldValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Price: </td>
                    <td class="auto-style5">&nbsp;&nbsp;
                        <asp:TextBox ID="ProductPrice" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="PriceValidator" runat="server" ControlToValidate="ProductPrice" ErrorMessage="Provide Price"></asp:RequiredFieldValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Product Description:</td>
                    <td class="auto-style5">&nbsp;&nbsp;
                        <asp:TextBox ID="ProductDescription" runat="server"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="DescriptionValidator" runat="server" ControlToValidate="ProductDescription" ErrorMessage="Provide Description"></asp:RequiredFieldValidator>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Brand Name:</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="BrandList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id" Height="31px" Width="133px">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AcuDataConnectionString5 %>" SelectCommand="SELECT [Id], [Name] FROM [Brand]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Image:&nbsp;&nbsp; </td>
                    <td class="auto-style5">
                        <asp:FileUpload ID="ImageFileUpload" runat="server" />
                    &nbsp;
                        <asp:RequiredFieldValidator ID="ImageValidator" runat="server" ControlToValidate="ImageFileUpload" ErrorMessage="Provide Image"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Height="37px" OnClick="Button1_Click1" Text="Add Data" Width="128px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                </tr>
            </table>

        </div>
</asp:Content>