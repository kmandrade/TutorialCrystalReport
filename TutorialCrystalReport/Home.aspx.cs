using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TutorialCrystalReport
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            string caminhoRelatorio = "~/DesignCrystalReport/CrystalReport.rpt";

            ReportDocument report = new ReportDocument();
            report.Load(Server.MapPath(caminhoRelatorio));



            ExportOptions exportOptions = new ExportOptions();
            exportOptions.ExportFormatType = ExportFormatType.PortableDocFormat; // Define o formato como PDF

            // caminho da área de trabalho
            string areaDeTrabalho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string caminhoDoArquivo = Path.Combine(areaDeTrabalho, "Relatorio.pdf");

            exportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
            exportOptions.DestinationOptions = new DiskFileDestinationOptions { DiskFileName = caminhoDoArquivo };

            report.Export(exportOptions);
            lblMensagem.Visible = true;
            lblMensagem.Text = "Relatório gerado com sucesso, veja na sua área de trabalho.";
        }
    }
}