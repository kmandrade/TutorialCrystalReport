<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="TutorialCrystalReport.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <link rel="stylesheet" type="text/css" href="TutorialCSS.css">

    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div class="centralizado">

            <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagens/images.png" Width="504px" />
        <br />
    </div>
        <h1>Relatório Crystal Report</h1>
        <asp:Panel ID="pnlPesquisa" runat="server" Visible="true">
            <table id="tblPesquisa" class="tabela" cellspacing="0" cellpadding="4" width="100%">
                <tr>
                    <td align="left" class="tabelaTitulo">Gerar Relatorio</td>
                </tr>
                
                <tr>
                    <td class="tabelaBotoes" align="center">
                        <asp:Button ID="btnGerarRelatorio" runat="server" Text="Gerar Relatorio"></asp:Button>
                    </td>

                </tr>
            </table>
        </asp:Panel>
        
          <table>
				<tr>
						<asp:validationsummary style="Z-INDEX: 0" id="vcErros" runat="server" DisplayMode="List"></asp:validationsummary>
				</tr>
			</table>
        <br />
                <asp:Label ID="lblMensagem" runat="server" Visible="False" ForeColor="Red"></asp:Label>
            <br />
        </form>
</body>
</html>
