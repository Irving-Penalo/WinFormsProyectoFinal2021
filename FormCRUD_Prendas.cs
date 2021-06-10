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

namespace WinFormsProyectoFinal2021
{
    public partial class FormCRUD_Prendas : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=BDProyectoFinal2021; Uid=root; pwd=;");
        public FormCRUD_Prendas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormCRUD_Prendas_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand comand = new MySqlCommand("select * from Prendas", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comand;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            PanelManipulacion.DataSource = tabla;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO Prendas (id_Prendas, id_Marca, id_Talla, id_Departamento, id_Proveedor, Nom_Prendas, Precio, Cantidad) values ('" + InputId.Text + "', '" + InputId_Marca.Text + "','" + InputId_Talla.Text + "', '" + InputId_Departamento.Text + "','" + InputId_Proveedor.Text + "','" + InputNombrePrendas.Text + "','" + InputPrecio.Text + "','" + InputCantidad.Text + "'); ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputId.Text}");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "UPDATE Prendas SET id_Prendas='" + InputId.Text +
                 "',id_Marca='" + InputId_Marca.Text +
                 "',id_Talla='" + InputId_Talla.Text +
                 "',id_Departamento='" + InputId_Departamento.Text +
                 "',id_Proveedor='" + InputId_Proveedor.Text +
                 "',Nom_Prendas='" + InputNombrePrendas.Text +
                 "',Precio='" + InputPrecio.Text +
                 "',Cantidad='" + InputCantidad.Text +
                 "'WHERE id_Prendas='" + InputId.Text +
                 "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputId.Text}");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "DELETE FROM Prendas WHERE id_Prendas='" + InputId.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"El registro {InputId.Text} ha sido eliminado");
        }
    }
}
