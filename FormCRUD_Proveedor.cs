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
    public partial class FormCRUD_Proveedor : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=BDProyectoFinal2021; Uid=root; pwd=;");
        public FormCRUD_Proveedor()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand comand = new MySqlCommand("select * from Proveedor", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comand;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            PanelManipulacion.DataSource = tabla;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO Proveedor (id_Proveedor, Nom_Proveedor) values ('" + InputId.Text + "', '" + InputNombre.Text + "');";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputNombre.Text}");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "UPDATE Proveedor SET id_Proveedor='" + InputId.Text +
                 "',Nom_Proveedor='" + InputNombre.Text +
                 "'WHERE id_Proveedor='" + InputId.Text +
                 "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputNombre.Text}");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "DELETE FROM Proveedor WHERE id_Proveedor='" + InputId.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"El registro {InputId.Text} ha sido eliminado");
        }
    }
}
