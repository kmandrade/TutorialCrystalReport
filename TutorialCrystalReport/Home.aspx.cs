using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=CrystalReport;Integrated Security=True"))
            {
                string query = @"SELECT IdComputador,
                                        NomePessoa,
                                        FORMAT(CAST(CPFPessoa AS bigint), '000\.000\.000\-00') AS CPFPessoa,
                                        CONVERT(varchar(10), DataCadastro, 103) AS DataCadastro FROM Computadores
                                ";
                SqlCommand cmd = new SqlCommand(query, conn);

                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                dataAdapter.Fill(dtt);
               
                string caminhoRelatorio = "~/DesignCrystalReport/CrystalReport.rpt";

                ReportDocument report = new ReportDocument();
                report.Load(Server.MapPath(caminhoRelatorio));

                report.SetDataSource(dtt);


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
}