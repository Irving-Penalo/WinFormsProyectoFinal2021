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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ninguno de los campos puede estar vacio");
            }
            else
            {
                if (textBox1.Text == "Irving" && textBox2.Text == "12345")
                {
                    FormUsuarioCentro AbrirFormularioUsuarioDashboard = new FormUsuarioCentro();
                    AbrirFormularioUsuarioDashboard.Show();
                    textBox1.Clear();
                    textBox2.Clear();

                }
                else
                {
                    MessageBox.Show("Revise las credenciales introducidas");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
