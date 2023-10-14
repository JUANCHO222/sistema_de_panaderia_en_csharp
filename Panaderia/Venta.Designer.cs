namespace Panaderia
{
    partial class Venta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboVenta = new System.Windows.Forms.ComboBox();
            this.comboPan = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.btn_DetalleVenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboPago = new System.Windows.Forms.ComboBox();
            this.comboV = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Regresar2 = new System.Windows.Forms.Button();
            this.btn_cz = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 414);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 26);
            this.textBox2.TabIndex = 6;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(140, 349);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(121, 28);
            this.comboCliente.TabIndex = 8;
            this.comboCliente.Click += new System.EventHandler(this.comboCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1415, 200);
            this.dataGridView1.TabIndex = 10;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_Buscar.Location = new System.Drawing.Point(97, 12);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(1338, 39);
            this.txt_Buscar.TabIndex = 11;
            this.txt_Buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Buscar_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Insertar Detalle Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Clave Detalle ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Clave Pan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 435);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Clave Venta";
            // 
            // comboVenta
            // 
            this.comboVenta.FormattingEnabled = true;
            this.comboVenta.Location = new System.Drawing.Point(460, 417);
            this.comboVenta.Name = "comboVenta";
            this.comboVenta.Size = new System.Drawing.Size(121, 28);
            this.comboVenta.TabIndex = 17;
            this.comboVenta.Click += new System.EventHandler(this.comboVenta_Click);
            // 
            // comboPan
            // 
            this.comboPan.FormattingEnabled = true;
            this.comboPan.Location = new System.Drawing.Point(460, 346);
            this.comboPan.Name = "comboPan";
            this.comboPan.Size = new System.Drawing.Size(121, 28);
            this.comboPan.TabIndex = 18;
            this.comboPan.Click += new System.EventHandler(this.comboPan_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(460, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 26);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(460, 385);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 26);
            this.textBox5.TabIndex = 20;
            // 
            // btn_Venta
            // 
            this.btn_Venta.Location = new System.Drawing.Point(186, 486);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(75, 34);
            this.btn_Venta.TabIndex = 21;
            this.btn_Venta.Text = "Insertar";
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // btn_DetalleVenta
            // 
            this.btn_DetalleVenta.Location = new System.Drawing.Point(506, 490);
            this.btn_DetalleVenta.Name = "btn_DetalleVenta";
            this.btn_DetalleVenta.Size = new System.Drawing.Size(75, 30);
            this.btn_DetalleVenta.TabIndex = 22;
            this.btn_DetalleVenta.Text = "Insertar";
            this.btn_DetalleVenta.UseVisualStyleBackColor = true;
            this.btn_DetalleVenta.Click += new System.EventHandler(this.btn_DetalleVenta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(881, 326);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(163, 26);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(881, 373);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(163, 26);
            this.textBox7.TabIndex = 25;
            // 
            // comboPago
            // 
            this.comboPago.FormattingEnabled = true;
            this.comboPago.Location = new System.Drawing.Point(881, 422);
            this.comboPago.Name = "comboPago";
            this.comboPago.Size = new System.Drawing.Size(163, 28);
            this.comboPago.TabIndex = 26;
            this.comboPago.Click += new System.EventHandler(this.comboPago_Click);
            // 
            // comboV
            // 
            this.comboV.FormattingEnabled = true;
            this.comboV.Location = new System.Drawing.Point(881, 465);
            this.comboV.Name = "comboV";
            this.comboV.Size = new System.Drawing.Size(163, 28);
            this.comboV.TabIndex = 27;
            this.comboV.Click += new System.EventHandler(this.comboV_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(675, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 33);
            this.label12.TabIndex = 28;
            this.label12.Text = "Pago";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(677, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Folio Pago";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(677, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Cantidad Pagada";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(677, 417);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Pago";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(677, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = "Venta";
            // 
            // btn_Regresar2
            // 
            this.btn_Regresar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar2.Location = new System.Drawing.Point(13, 704);
            this.btn_Regresar2.Name = "btn_Regresar2";
            this.btn_Regresar2.Size = new System.Drawing.Size(174, 58);
            this.btn_Regresar2.TabIndex = 33;
            this.btn_Regresar2.Text = "Regresar";
            this.btn_Regresar2.UseVisualStyleBackColor = true;
            this.btn_Regresar2.Click += new System.EventHandler(this.btn_Regresar2_Click);
            // 
            // btn_cz
            // 
            this.btn_cz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cz.Location = new System.Drawing.Point(1094, 704);
            this.btn_cz.Name = "btn_cz";
            this.btn_cz.Size = new System.Drawing.Size(211, 58);
            this.btn_cz.TabIndex = 34;
            this.btn_cz.Text = "Agregar nuevo cliente/zona";
            this.btn_cz.UseVisualStyleBackColor = true;
            this.btn_cz.Click += new System.EventHandler(this.btn_cz_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(140, 382);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 26);
            this.textBox8.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 382);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Hora";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 454);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 26);
            this.textBox3.TabIndex = 7;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 849);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btn_cz);
            this.Controls.Add(this.btn_Regresar2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboV);
            this.Controls.Add(this.comboPago);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DetalleVenta);
            this.Controls.Add(this.btn_Venta);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboPan);
            this.Controls.Add(this.comboVenta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Venta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboVenta;
        private System.Windows.Forms.ComboBox comboPan;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Button btn_DetalleVenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboPago;
        private System.Windows.Forms.ComboBox comboV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Regresar2;
        private System.Windows.Forms.Button btn_cz;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
    }
}

