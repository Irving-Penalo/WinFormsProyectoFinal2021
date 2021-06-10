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
    public partial class FormCRUD_Ventas : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=BDProyectoFinal2021; Uid=root; pwd=;");
        public FormCRUD_Ventas()
        {
            InitializeComponent();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            MySqlCommand comand = new MySqlCommand("select * from Ventas", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            adaptador.SelectCommand = comand;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            PanelManipulacion.DataSource = tabla;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "INSERT INTO Ventas (id_Ventas, Id_Prenda, Id_Cliente,Fecha) values ('" + InputId.Text + "', '" + InputId_Prenda.Text + "','" + InputId_Cliente.Text + "','" + InputFecha.Text+"'); ";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputId.Text}");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "UPDATE Ventas SET id_Ventas='" + InputId.Text +
                 "',Id_Prenda='" + InputId_Prenda.Text +
                 "',Id_Cliente='" + InputId_Cliente.Text +
                 "',Fecha='" + InputFecha.Text +
                 "'WHERE id_Ventas='" + InputId.Text +
                 "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"Se agrego el nuevo registro {InputId.Text}");
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Query = "DELETE FROM Ventas WHERE id_Ventas='" + InputId.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show($"El registro {InputId.Text} ha sido eliminado");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
