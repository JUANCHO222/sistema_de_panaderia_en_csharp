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
    public partial class Cliente_Zona : Form
    {
        public Cliente_Zona()
        {
            InitializeComponent();
        }

        private void Cliente_Zona_Load(object sender, EventArgs e)
        {
            ConexionMaestra.conectar();
        }

        private void btn_Zona_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
             " CALL insertar_zona('" +
             textBox5.Text + "', '" +
             textBox6.Text + "', '" +
             textBox7.Text + "')"
              );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void comboZona_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboZona, "SELECT Localidad FROM zona");
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
            " CALL insertar_cliente('" +
            textBox1.Text + "', '" +
            textBox2.Text + "', '" +
            textBox3.Text + "', '" +
            textBox4.Text + "', '" +
            comboZona.Text + "')"
             );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void comboCliente_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboCliente, "SELECT Nombre FROM Cliente");
        }

        private void btn_Bitacora_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
            " CALL insertar_bitacora('" +
            textBox8.Text + "', '" +
            comboCliente.Text + "', '" +
            textBox9.Text + "', '" +
            textBox10.Text + "')"
             );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void txt_Cliente_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra.gred(dataGridView1, "call buscar_cliente('%"
               + txt_Cliente.Text + "%')");
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Venta frm = new Venta();
            frm.Show();
            this.Hide();
        }
    }
}
