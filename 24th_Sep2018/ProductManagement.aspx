<%@ Page Language="C#" ViewStateMode="Disabled"  AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="_24th_Sep2018.ProductManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 457px;
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            position: relative;
            left: 74px;
            top: 0px;
            height: 446px;
            width: 787px;
            font-size: medium;
            text-align: left;
        }
    </style>
</head>
<body style="height: 487px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            Product Management<div class="auto-style2">
                &nbsp;<asp:Button ID="Insert" runat="server" Height="48px" OnClick="Insert_Click" Text="Insert" Width="154px" />
                <br />
                <br />
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </form>
</body>
</html>
