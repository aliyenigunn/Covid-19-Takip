<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Covid_19._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Covid-19 Takip Sistemi</title>
    <style type="text/css" >
        .logo{
            width:512px;
            height:512px;
            background-image:url(logo.png);
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
    <form id="form1" runat="server" >
        <div  style="background-color: blueviolet; width: auto; height: 900px">
            <h1 style="text-align:center ;font-size:30px ">Covid-19 Takip Sistemi  </h1>
            <div class="logo" style="margin-top:75px;margin-left:650px"></div>
            <div >
                <table id="Table1" runat="server" style="margin-left:auto;margin-right:auto;margin-top:140px">
                    <tr>
                        <td><asp:Button ID="Button1" runat="server" class="buton" Text="Hasta Kayıt"  Height="35px"  Width="250px" OnClick="btnhastakayit" /> </td>
                        <td><asp:Button ID="Button2" runat="server" class="buton" Text="Temaslı Hasta Kayıt" Height="35px"  Width="250px" OnClick="btntemaslikayit"/></td>
                        <td><asp:Button ID="Button3" runat="server" class="buton" Text="Filyasyon Ekip Kaydı" Height="35px"  Width="250px" OnClick="btnfilkayit"/></td>
                        <td><asp:Button ID="Button4" runat="server" class="buton" Text="Filyasyon Ekip Ataması" Height="35px"  Width="250px" OnClick="btnfilatama"/></td>
                        
                    </tr>

                </table>
            </div>

            
        </div>
    </form>
</body>
</html>
