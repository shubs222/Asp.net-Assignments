<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="_24th_Sep2018.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 560px;
        }
        .auto-style2 {
            position: relative;
            left: 0px;
            top: 56px;
            height: 434px;
            text-align: center;
        }
        .auto-style3 {
            position: relative;
            left: 44px;
            top: 3px;
            height: 32px;
            width: 133px;
        }
    </style>
</head>
<body>
   
    
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 style="text-align:center">Insert Your Products</h1>
            <div class="auto-style2">
                Product Name:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                Price:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                Description:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                Image Url:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                <br />
                Select Brand:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id" Height="39px" Width="140px">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AcuDataConnectionString %>" SelectCommand="SELECT [Id], [Name] FROM [Brand]"></asp:SqlDataSource>
                <br />
                <br />
                <br />
                <asp:Button ID="AddProduct" runat="server" CssClass="auto-style3" OnClick="AddProduct_Click" Text="Add Product" />
            </div>
        </div>
    </form>
</body>
</html>
