<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jogoDaForca.aspx.cs" Inherits="prjJogoDaforca.jogoDaForca" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="CSS/StyleSheet1.css" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="central">
            <div class ="Conteiner">
                <asp:Image class="img" ID="cabeça" runat="server" /><br />
                <asp:Image class="img" ID="corpo" runat="server" /><br />
                <asp:Image class="img" ID="perna" runat="server" /><br />
                 <asp:TextBox ID="txtNome" runat="server" Width="125px"></asp:TextBox>
              <asp:Button ID="BtnJogo" runat="server" Text="Jogar" Width="59px" OnClick="Button1_Click" /><br />
              <asp:Button ID="BtnReiniciar" runat="server" Text="Reinicia" Width="76px" OnClick="BtnReiniciar_Click" /><br />
            </div>
             
            <div class ="lbl">
                 <asp:Label ID="Lbl1" runat="server" Text=""></asp:Label>
                 <asp:Label ID="Lbl2" runat="server" Text=""></asp:Label>
                 <asp:Label ID="Lbl3" runat="server" Text=""></asp:Label>
            </div>
           
        </div>
    </form>
</body>
</html>
