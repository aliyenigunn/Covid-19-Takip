<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="detaygrup.aspx.cs" Inherits="Covid_19.detaygrup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Filyasyon Ekip Detayları</title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:blueviolet ; width:auto;height:900px ">
           <h1 style="text-align:center ;font-size:30px ">Filyasyon Ekip Detayları</h1>
        
        <div>
            <asp:GridView ID="GridView1" runat="server" style="margin-top:100px; " AutoGenerateColumns="False"  BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" CssClass="auto-style1" Width="1500px" Height="300px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="ekipadi" HeaderText="EKİP ADI" SortExpression="ekipadi" />
                    <asp:BoundField DataField="tcno" HeaderText="TC NO" SortExpression="tcno" />
                    <asp:BoundField DataField="filadsoyad" HeaderText="AY SOYAD" SortExpression="filadsoyad" />
                    <asp:BoundField DataField="cinsiyet" HeaderText="CİNSİYET" SortExpression="cinsiyet" />
                    <asp:BoundField DataField="yas" HeaderText="YAŞ" SortExpression="yas" />
                    <asp:BoundField DataField="meslek" HeaderText="MESLEK" SortExpression="meslek" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:covid19ConnectionString %>" SelectCommand="SELECT [ekipadi], [tcno], [filadsoyad], [cinsiyet], [yas], [meslek] FROM [filyasyonbilgi]"></asp:SqlDataSource>
        </div>

            <div style="margin-top:200px;margin-left:850px">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/back.png" OnClick="btngeri" />
        </div>
        
        </div>
    </form>
</body>
</html>
