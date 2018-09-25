<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetail.aspx.cs" Inherits="_24th_Sep2018.ProductDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 442px;
            text-align: center;
        }
        .auto-style2 {
            height: 367px;
            position: relative;
            left: 0px;
            top: 44px;
        }
        .auto-style3 {
            position: relative;
            left: -197px;
            top: 55px;
            width: 211px;
            height: 200px;
        }
        .auto-style4 {
            position: relative;
            left: 391px;
            top: -194px;
            width: 546px;
            height: 363px;
        }
        .auto-style5 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="position: relative">
            Products Detail:<div class="auto-style2">
                <asp:Image ID="Image1" runat="server" CssClass="auto-style3" />
                <div class="auto-style4">
                    <em><strong>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style5" Text="Label"></asp:Label>
                    </strong></em>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
