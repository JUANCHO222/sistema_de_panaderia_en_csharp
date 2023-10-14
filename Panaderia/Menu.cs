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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Panes_Click(object sender, EventArgs e)
        {
            Producto frm = new Producto();
            frm.Show();
            this.Hide();
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            Venta frm = new Venta();
            frm.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
