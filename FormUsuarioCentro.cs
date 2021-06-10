using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProyectoFinal2021
{
    public partial class FormUsuarioCentro : Form
    {
        public FormUsuarioCentro()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es la aplicacion que diseñamos en el tecnico del CELA");
        }

        private void registrosDePrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void capturaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCapturaDatos AbrirformCapturaDatos = new FormCapturaDatos();
            AbrirformCapturaDatos.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Marca AbrirformCRUD_Marca = new FormCRUD_Marca();
            AbrirformCRUD_Marca.Show();
        }

        private void tallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Talla AbrirformCRUD_Talla = new FormCRUD_Talla();
            AbrirformCRUD_Talla.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Departamento AbrirformCRUD_Departamento = new FormCRUD_Departamento();
            AbrirformCRUD_Departamento.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Proveedor AbrirformCRUD_Proveedor = new FormCRUD_Proveedor();
            AbrirformCRUD_Proveedor.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Cliente AbrirformCRUD_Cliente = new FormCRUD_Cliente();
            AbrirformCRUD_Cliente.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Ventas AbrirformCRUD_Ventas = new FormCRUD_Ventas();
            AbrirformCRUD_Ventas.Show();
        }

        private void prendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCRUD_Prendas AbrirformCRUD_Prendas = new FormCRUD_Prendas();
            AbrirformCRUD_Prendas.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void reporteDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteCliente AbrirformReporteCliente = new FormReporteCliente();
            AbrirformReporteCliente.Show();
        }

        private void reporteDePrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportesPrendas AbrirformReportesPrendas = new FormReportesPrendas();
            AbrirformReportesPrendas.Show();
        }

        private void reporteDeFechaEspecificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteFechaEspecifca AbrirformReporteFechaEspecifca = new FormReporteFechaEspecifca();
            AbrirformReporteFechaEspecifca.Show();
        }
    }
}
