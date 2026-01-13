
namespace Sistema_de_facturacion
{
    partial class Menu_principal
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
            this.RM = new System.Windows.Forms.GroupBox();
            this.Usuariobutton = new System.Windows.Forms.RadioButton();
            this.Clientebutton = new System.Windows.Forms.RadioButton();
            this.Articulobutton = new System.Windows.Forms.RadioButton();
            this.Consultas = new System.Windows.Forms.GroupBox();
            this.CXCobrar = new System.Windows.Forms.RadioButton();
            this.Stocik = new System.Windows.Forms.RadioButton();
            this.Ventas = new System.Windows.Forms.RadioButton();
            this.Procesos = new System.Windows.Forms.GroupBox();
            this.Facturacion = new System.Windows.Forms.RadioButton();
            this.Reportes = new System.Windows.Forms.GroupBox();
            this.Clientes = new System.Windows.Forms.RadioButton();
            this.Articulos = new System.Windows.Forms.RadioButton();
            this.Salir = new System.Windows.Forms.Button();
            this.Reporteventas = new System.Windows.Forms.RadioButton();
            this.RM.SuspendLayout();
            this.Consultas.SuspendLayout();
            this.Procesos.SuspendLayout();
            this.Reportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // RM
            // 
            this.RM.BackColor = System.Drawing.Color.Red;
            this.RM.Controls.Add(this.Usuariobutton);
            this.RM.Controls.Add(this.Clientebutton);
            this.RM.Controls.Add(this.Articulobutton);
            this.RM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RM.Location = new System.Drawing.Point(63, 21);
            this.RM.Margin = new System.Windows.Forms.Padding(2);
            this.RM.Name = "RM";
            this.RM.Padding = new System.Windows.Forms.Padding(2);
            this.RM.Size = new System.Drawing.Size(362, 222);
            this.RM.TabIndex = 0;
            this.RM.TabStop = false;
            this.RM.Text = "Registros y Mantenimientos";
            // 
            // Usuariobutton
            // 
            this.Usuariobutton.AutoSize = true;
            this.Usuariobutton.CausesValidation = false;
            this.Usuariobutton.Location = new System.Drawing.Point(16, 123);
            this.Usuariobutton.Margin = new System.Windows.Forms.Padding(2);
            this.Usuariobutton.Name = "Usuariobutton";
            this.Usuariobutton.Size = new System.Drawing.Size(104, 29);
            this.Usuariobutton.TabIndex = 8;
            this.Usuariobutton.Text = "Usuario";
            this.Usuariobutton.UseVisualStyleBackColor = true;
            this.Usuariobutton.Click += new System.EventHandler(this.radioButton3_Click_1);
            // 
            // Clientebutton
            // 
            this.Clientebutton.AutoSize = true;
            this.Clientebutton.Location = new System.Drawing.Point(15, 84);
            this.Clientebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Clientebutton.Name = "Clientebutton";
            this.Clientebutton.Size = new System.Drawing.Size(98, 29);
            this.Clientebutton.TabIndex = 7;
            this.Clientebutton.Text = "Cliente";
            this.Clientebutton.UseVisualStyleBackColor = true;
            this.Clientebutton.Click += new System.EventHandler(this.radioButton2_Click_1);
            // 
            // Articulobutton
            // 
            this.Articulobutton.AutoSize = true;
            this.Articulobutton.Location = new System.Drawing.Point(16, 43);
            this.Articulobutton.Margin = new System.Windows.Forms.Padding(2);
            this.Articulobutton.Name = "Articulobutton";
            this.Articulobutton.Size = new System.Drawing.Size(103, 29);
            this.Articulobutton.TabIndex = 6;
            this.Articulobutton.Text = "Articulo";
            this.Articulobutton.UseVisualStyleBackColor = true;
            this.Articulobutton.Click += new System.EventHandler(this.radioButton1_Click_1);
            // 
            // Consultas
            // 
            this.Consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Consultas.Controls.Add(this.CXCobrar);
            this.Consultas.Controls.Add(this.Stocik);
            this.Consultas.Controls.Add(this.Ventas);
            this.Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultas.Location = new System.Drawing.Point(63, 265);
            this.Consultas.Margin = new System.Windows.Forms.Padding(2);
            this.Consultas.Name = "Consultas";
            this.Consultas.Padding = new System.Windows.Forms.Padding(2);
            this.Consultas.Size = new System.Drawing.Size(362, 224);
            this.Consultas.TabIndex = 1;
            this.Consultas.TabStop = false;
            this.Consultas.Text = "Consultas";
            // 
            // CXCobrar
            // 
            this.CXCobrar.AutoSize = true;
            this.CXCobrar.Location = new System.Drawing.Point(16, 158);
            this.CXCobrar.Margin = new System.Windows.Forms.Padding(2);
            this.CXCobrar.Name = "CXCobrar";
            this.CXCobrar.Size = new System.Drawing.Size(215, 29);
            this.CXCobrar.TabIndex = 6;
            this.CXCobrar.TabStop = true;
            this.CXCobrar.Text = "Cuentas por cobrar";
            this.CXCobrar.UseVisualStyleBackColor = true;
            this.CXCobrar.Click += new System.EventHandler(this.CXCobrar_Click);
            // 
            // Stocik
            // 
            this.Stocik.AutoSize = true;
            this.Stocik.Location = new System.Drawing.Point(16, 106);
            this.Stocik.Margin = new System.Windows.Forms.Padding(2);
            this.Stocik.Name = "Stocik";
            this.Stocik.Size = new System.Drawing.Size(261, 29);
            this.Stocik.TabIndex = 5;
            this.Stocik.TabStop = true;
            this.Stocik.Text = "Consulta de stock bajos";
            this.Stocik.UseVisualStyleBackColor = true;
            this.Stocik.Click += new System.EventHandler(this.Stocik_Click);
            // 
            // Ventas
            // 
            this.Ventas.AutoSize = true;
            this.Ventas.Location = new System.Drawing.Point(15, 55);
            this.Ventas.Margin = new System.Windows.Forms.Padding(2);
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(98, 29);
            this.Ventas.TabIndex = 4;
            this.Ventas.TabStop = true;
            this.Ventas.Text = "Ventas";
            this.Ventas.UseVisualStyleBackColor = true;
            // 
            // Procesos
            // 
            this.Procesos.BackColor = System.Drawing.Color.Yellow;
            this.Procesos.Controls.Add(this.Facturacion);
            this.Procesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesos.Location = new System.Drawing.Point(456, 21);
            this.Procesos.Margin = new System.Windows.Forms.Padding(2);
            this.Procesos.Name = "Procesos";
            this.Procesos.Padding = new System.Windows.Forms.Padding(2);
            this.Procesos.Size = new System.Drawing.Size(377, 226);
            this.Procesos.TabIndex = 1;
            this.Procesos.TabStop = false;
            this.Procesos.Text = "Procesos";
            // 
            // Facturacion
            // 
            this.Facturacion.AutoSize = true;
            this.Facturacion.Location = new System.Drawing.Point(15, 43);
            this.Facturacion.Margin = new System.Windows.Forms.Padding(2);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(143, 29);
            this.Facturacion.TabIndex = 3;
            this.Facturacion.TabStop = true;
            this.Facturacion.Text = "Facturacion";
            this.Facturacion.UseVisualStyleBackColor = true;
            this.Facturacion.Click += new System.EventHandler(this.Facturacion_Click);
            // 
            // Reportes
            // 
            this.Reportes.BackColor = System.Drawing.Color.Blue;
            this.Reportes.Controls.Add(this.Reporteventas);
            this.Reportes.Controls.Add(this.Clientes);
            this.Reportes.Controls.Add(this.Articulos);
            this.Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.Location = new System.Drawing.Point(456, 265);
            this.Reportes.Margin = new System.Windows.Forms.Padding(2);
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(2);
            this.Reportes.Size = new System.Drawing.Size(377, 224);
            this.Reportes.TabIndex = 1;
            this.Reportes.TabStop = false;
            this.Reportes.Text = "Reportes";
            // 
            // Clientes
            // 
            this.Clientes.AutoSize = true;
            this.Clientes.Location = new System.Drawing.Point(15, 95);
            this.Clientes.Margin = new System.Windows.Forms.Padding(2);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(109, 29);
            this.Clientes.TabIndex = 5;
            this.Clientes.TabStop = true;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // Articulos
            // 
            this.Articulos.AutoCheck = false;
            this.Articulos.AutoSize = true;
            this.Articulos.Location = new System.Drawing.Point(15, 55);
            this.Articulos.Margin = new System.Windows.Forms.Padding(2);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(114, 29);
            this.Articulos.TabIndex = 4;
            this.Articulos.TabStop = true;
            this.Articulos.Text = "Articulos";
            this.Articulos.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.AutoSize = true;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(272, 503);
            this.Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(353, 82);
            this.Salir.TabIndex = 2;
            this.Salir.Text = "Salir del sistema";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Reporteventas
            // 
            this.Reporteventas.AutoSize = true;
            this.Reporteventas.Location = new System.Drawing.Point(17, 143);
            this.Reporteventas.Margin = new System.Windows.Forms.Padding(2);
            this.Reporteventas.Name = "Reporteventas";
            this.Reporteventas.Size = new System.Drawing.Size(245, 29);
            this.Reporteventas.TabIndex = 6;
            this.Reporteventas.TabStop = true;
            this.Reporteventas.Text = "Reporte ventas diarias";
            this.Reporteventas.UseVisualStyleBackColor = true;
            this.Reporteventas.Click += new System.EventHandler(this.Reporteventas_Click);
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 599);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Reportes);
            this.Controls.Add(this.Procesos);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.RM);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Menu_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_principal";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            this.RM.ResumeLayout(false);
            this.RM.PerformLayout();
            this.Consultas.ResumeLayout(false);
            this.Consultas.PerformLayout();
            this.Procesos.ResumeLayout(false);
            this.Procesos.PerformLayout();
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RM;
        private System.Windows.Forms.GroupBox Consultas;
        private System.Windows.Forms.RadioButton Ventas;
        private System.Windows.Forms.GroupBox Procesos;
        private System.Windows.Forms.RadioButton Facturacion;
        private System.Windows.Forms.GroupBox Reportes;
        private System.Windows.Forms.RadioButton Clientes;
        private System.Windows.Forms.RadioButton Articulos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.RadioButton Articulobutton;
        private System.Windows.Forms.RadioButton Clientebutton;
        private System.Windows.Forms.RadioButton Usuariobutton;
        private System.Windows.Forms.RadioButton Stocik;
        private System.Windows.Forms.RadioButton CXCobrar;
        private System.Windows.Forms.RadioButton Reporteventas;
    }
}