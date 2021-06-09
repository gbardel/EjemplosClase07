<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculateDaySVC.aspx.cs" Inherits="CalculateDaysSVC.CalculateDaySVC" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Operaciones con días</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Cantidad de días hasta la fecha actual</h2>
        </div>
        <div>
            <asp:Label ID="lblDay" runat="server" Text="Dia"></asp:Label>
            <asp:TextBox ID="txtDay" runat="server" ></asp:TextBox>
            <asp:Label ID="lblMonth" runat="server" Text="Mes"></asp:Label>
            <asp:TextBox ID="txtMonth" runat="server" ></asp:TextBox>
            <asp:Label ID="lblYear" runat="server" Text="Año"></asp:Label>
            <asp:TextBox ID="txtYear" runat="server" ></asp:TextBox>
            <asp:Button  ID="btnCalcularConvertToDays" runat="server" Text="Calcular" OnClick="btnCalcularConvertToDays_Click" />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div>
        <div>
            <h2>Cantidad de días entre dos fechas</h2>
        </div>
         <div>
            <asp:Label ID="Label1" runat="server" Text="Dia"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Mes"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Año"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
             <asp:Label ID="Label5" runat="server" Text="Dia"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="Mes"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
            <asp:Label ID="Label7" runat="server" Text="Año"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox>
            <asp:Button  ID="Button1" runat="server" Text="Calcular" OnClick="btnCalcularCDaysBetweenDays_Click" />
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </div>
        <div>
           <!-- Completar con otro bloque para invocar a otro metodo del web service-->
        </div>
    </form>
</body>
</html>
