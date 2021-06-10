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
    public partial class FormCRUD_Cliente : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=BDProyectoFinal2021; Uid=root; pwd=;");
        public FormCRUD_Cliente()
        {
            InitializeComponent();
        }

        private void FormCRUD_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO Cliente (id_Cliente, Nom_Cliente, Direccion) values ('" + InputId.Text + "', '" + InputNombre.Text + "','" + InputDireccion.Text +"'); ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputNombre.Text}");
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand comand = new MySqlCommand("select * from Cliente", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comand;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            PanelManipulacion.DataSource = tabla;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "UPDATE Cliente SET id_Cliente='" + InputId.Text +
                 "',Nom_Cliente='" + InputNombre.Text +
                 "',Direccion='" + InputDireccion.Text +
                 "'WHERE id_Cliente='" + InputId.Text +
                 "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputNombre.Text}");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "DELETE FROM Cliente WHERE id_Cliente='" + InputId.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"El registro {InputId.Text} ha sido eliminado");
        }
    }
}
