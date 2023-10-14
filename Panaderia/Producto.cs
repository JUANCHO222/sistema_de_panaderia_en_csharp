using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panaderia
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            ConexionMaestra.conectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
             " CALL insertar_pan('" +
             textBox1.Text + "', '" +
             textBox2.Text + "', '" +
             textBox3.Text + "', '" +
             textBox4.Text + "', '" +
             textBox5.Text + "', '" +
             textBox6.Text + "')"
              );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void txt_buscarPan_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra.gred(dataGridView1, "call buscar_pan('%"
               + txt_buscarPan.Text + "%')");
        }

        private void btn_Regresar1_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }
    }
}
