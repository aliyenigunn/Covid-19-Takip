<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="grupgoruntule.aspx.cs" Inherits="Covid_19.grupgoruntule" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Filyasyon Ekipleri Görüntüle</title>
    <style type="text/css">
         .tablo{
            font-weight:bold;
            font-size:20px;
        }
        .ortala{
            margin-top:70px;
            margin-left:560px;
        }
        .buton {
	        box-shadow:inset 0px 1px 0px 0px #ffffff;
	        background:linear-gradient(to bottom, #ededed 5%, #dfdfdf 100%);
	        background-color:#ededed;
	        border-radius:6px;
	        border:1px solid #8a8a8a;
	        display:inline-block;
	        cursor:pointer;
	        color:#000000;
	        font-family:Arial;
	        font-size:17px;
	        font-weight:bold;
	        padding:6px 24px;
	        text-decoration:none;
	        text-shadow:0px 1px 0px #ffffff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:blueviolet ; width:auto;height:900px ">
            <h1 style="text-align:center ;font-size:30px ">Filyasyon Ekipleri Görüntüle</h1>
            
         <div>
             <table class="ortala" style="width:100px">
                 <tr>
                     <td><asp:DropDownList ID="cbekip" runat="server" Height="35px" Width="405px">
                         <asp:ListItem>EKİP SEÇİNİZ</asp:ListItem>
                         </asp:DropDownList></td>
                     <td><asp:Button ID="btnekipyukle" runat="server" Class="buton" Height="35px" Width="210px" Text="EKİP YÜKLE" OnClick="btnyukle" /></td>
                     <td><asp:Button ID="btnekipgor" runat="server" Class="buton" Height="35px" Width="210px" Text="EKİP GÖRÜNTÜLE" OnClick="btngoruntule" /></td>
                 </tr>
                 
             </table>
         
          <div>
              <asp:GridView ID="GridView1" runat="server" style="margin-top:100px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3"  ForeColor="Black" GridLines="Vertical" Width="1500px" Height="200px" HorizontalAlign="Center">
              
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


          </div>
        </div>
            <div style="margin-top:200px;margin-left:850px">
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/back.png" OnClick="btngeri" />
        </div>
        </div>
    </form>
</body>
</html>
