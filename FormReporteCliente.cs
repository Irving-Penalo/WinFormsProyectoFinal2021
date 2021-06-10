using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace WinFormsProyectoFinal2021
{
    public partial class FormReporteCliente : Form
    {
        public FormReporteCliente()
        {
            InitializeComponent();
        }

        private void FormReporteCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("Server=localhost; Database=BDProyectoFinal2021; Uid= root; Pwd=;");

            DataTable dt = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from Cliente", cn);
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource Rp = new ReportDataSource("DataSetReporteCliente", dt);

            reportViewer1.LocalReport.DataSources.Add(Rp);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
