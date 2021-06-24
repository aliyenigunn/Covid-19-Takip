<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="filyasyonkayit.aspx.cs" Inherits="Covid_19.filyasyonkayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Filyasyon Ekip Kayıt Ekleme</title>
    <style type="text/css">
        .tablo{
            font-weight:bold;
            font-size:20px;
        }
        .ortala{
            margin-top:100px;
            margin-left:560px;
        }
        .auto-style1 {
            font-weight: bold;
            font-size: 20px;
            width: 200px;
        }
        .logo{
            width:128px;
            height:128px;
            background-image:url(add.png);
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
            <h1 style="text-align:center ;font-size:30px ">Filyasyon Ekip Kayıt Ekleme </h1>
            <div class="logo" style="margin-top:75px;margin-left:850px">

            </div>
            
            <div>
                <table class="ortala" style="width: 100%;">
                     <tr>
                        <td class="auto-style1" >GRUP ADI</td>
                        <td class="tablo"> : </td>
                        <td><asp:TextBox ID="txtgrupad" runat="server" Height="25px" Width="400px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" >TC KİMLİK NO</td>
                        <td class="tablo"> : </td>
                        <td><asp:TextBox ID="txttc" runat="server" Height="25px" Width="400px"></asp:TextBox></td>
                    </tr>
                   <tr>
                        <td class="auto-style1" >AD SOYAD</td>
                        <td class="tablo"> : </td>
                        <td><asp:TextBox ID="txtadsoyad" runat="server" Height="25px" Width="400px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="auto-style1" >CİNSİYET</td>
                        <td class="tablo"> : </td>
                        <td><asp:DropDownList ID="cbcinsiyet" runat="server" Height="25px" Width="405px">
                            <asp:ListItem>SEÇİNİZ</asp:ListItem>
                            <asp:ListItem>ERKEK</asp:ListItem>
                            <asp:ListItem>KADIN</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>     
                     <tr>
                        <td class="auto-style1" >YAŞ</td>
                        <td class="tablo"> : </td>
                        <td><asp:TextBox ID="txtyas" runat="server" Height="25px" Width="400px"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td class="auto-style1" >MESLEK</td>
                        <td class="tablo"> : </td>
                        <td><asp:DropDownList ID="cbmeslek" runat="server" Height="25px" Width="405px">
                            <asp:ListItem>SEÇİNİZ</asp:ListItem>
                            <asp:ListItem>DOKTOR</asp:ListItem>
                            <asp:ListItem>HEMŞİRE</asp:ListItem>
                            <asp:ListItem>HEMŞİRE YARDIMCISI</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>     
                    
                </table>
                <table class="ortala" style="width:50px; margin-left:580px">
                    <tr>
                        <td><asp:Button ID="btnekle" runat="server" Class="buton" Height="35px" Width="210px" Text="EKLE" OnClick="btnhastaekle" /></td>
                        <td><asp:Button ID="btngoster" runat="server" Class="buton" Height="35px" Width="210px" Text="GRUP GÖRÜNTÜLE" OnClick="btngrupgor" /></td>
                        <td><asp:Button ID="btntemizle" runat="server" Class="buton" Height="35px" Width="210px" Text="TEMİZLE" OnClick="btnmetintemizle" /></td>  
                    </tr>
                    
                </table>
                <div style="margin-top:160px;margin-left:850px">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/back.png" OnClick="btngeri" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
