namespace Panaderia
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Panes = new System.Windows.Forms.Button();
            this.btn_Venta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Panes
            // 
            this.btn_Panes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Panes.Location = new System.Drawing.Point(12, 357);
            this.btn_Panes.Name = "btn_Panes";
            this.btn_Panes.Size = new System.Drawing.Size(190, 51);
            this.btn_Panes.TabIndex = 0;
            this.btn_Panes.Text = "Panes";
            this.btn_Panes.UseVisualStyleBackColor = true;
            this.btn_Panes.Click += new System.EventHandler(this.btn_Panes_Click);
            // 
            // btn_Venta
            // 
            this.btn_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Venta.Location = new System.Drawing.Point(530, 357);
            this.btn_Venta.Name = "btn_Venta";
            this.btn_Venta.Size = new System.Drawing.Size(205, 51);
            this.btn_Venta.TabIndex = 1;
            this.btn_Venta.Text = "Venta";
            this.btn_Venta.UseVisualStyleBackColor = true;
            this.btn_Venta.Click += new System.EventHandler(this.btn_Venta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Panaderia Don Guillermo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Venta);
            this.Controls.Add(this.btn_Panes);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Panes;
        private System.Windows.Forms.Button btn_Venta;
        private System.Windows.Forms.Label label1;
    }
}