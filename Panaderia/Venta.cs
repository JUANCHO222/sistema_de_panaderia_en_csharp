using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Panaderia
{
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionMaestra.conectar();
        }

        private void txt_Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            ConexionMaestra.gred(dataGridView1, "call buscar_venta('%"
               + txt_Buscar.Text + "%')");
        }

        private void comboPan_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboPan, "SELECT Nombre FROM pan ORDER BY Nombre");
        }

        private void comboVenta_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboVenta, "SELECT Folio_V FROM Venta");
        }

        private void comboCliente_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboCliente, "SELECT Nombre FROM Cliente ORDER BY Nombre");
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
             " CALL insertar_Venta('" +
             textBox1.Text + "', '" +
             comboCliente.Text + "', '" +
             textBox8.Text + "', '" +
             textBox2.Text + "', '" +
             textBox3.Text + "')"
              );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void btn_DetalleVenta_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
            " CALL insertar_DetalleV('" +
            textBox4.Text + "', '" +
            comboPan.Text + "', '" +
            textBox5.Text + "', '" +
            comboVenta.Text + "')"
             );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void comboPago_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboPago, "SELECT Tipo_P FROM tipopago");
        }

        private void comboV_Click(object sender, EventArgs e)
        {
            ConexionMaestra.llenaCombo(comboV, "SELECT Folio_V FROM venta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionMaestra.ejecutar(
            " CALL insertar_DetalleP('" +
            textBox6.Text + "', '" +
            textBox7.Text + "', '" +
            comboPago.Text + "', '" +
            comboV.Text + "')"
             );
            ConexionMaestra.leer.Close();
            MessageBox.Show("Registro exitoso");
        }

        private void btn_Regresar2_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void btn_cz_Click(object sender, EventArgs e)
        {
            Cliente_Zona frm = new Cliente_Zona();
            frm.Show();
            this.Hide();
        }
    }
}
