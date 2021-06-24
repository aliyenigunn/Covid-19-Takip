<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="temaslihastagoruntule.aspx.cs" Inherits="Covid_19.temaslıhastagoruntule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:blueviolet ; width:auto;height:900px ">
            <h1 style="text-align:center ;font-size:30px ">Temaslı Hastaları Görüntüle</h1>
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"  ForeColor="Black" GridLines="Vertical" Width="1500px" Height="200px" HorizontalAlign="Center">
              
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        <div style="margin-top:530px;margin-left:850px">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/back.png" OnClick="btngeri" />
        </div>
        </div>
        </div>
        
    </form>
</body>
</html>
