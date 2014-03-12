<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmpleadosWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label>Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <label>Apellido</label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <label>Edad</label>
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <label>Sueldo</label>
        <asp:TextBox ID="txtSueldo" runat="server"></asp:TextBox>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
    </form>
</body>
</html>
