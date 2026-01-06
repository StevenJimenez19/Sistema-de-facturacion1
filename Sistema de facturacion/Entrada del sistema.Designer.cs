
namespace Sistema_de_facturacion
{
    partial class Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrada));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuarioent = new System.Windows.Forms.TextBox();
            this.Contrasenaent = new System.Windows.Forms.TextBox();
            this.Entrarboton = new System.Windows.Forms.PictureBox();
            this.Salirboton = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Entrarboton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salirboton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena ";
            // 
            // Usuarioent
            // 
            this.Usuarioent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuarioent.Location = new System.Drawing.Point(401, 70);
            this.Usuarioent.Margin = new System.Windows.Forms.Padding(2);
            this.Usuarioent.Name = "Usuarioent";
            this.Usuarioent.Size = new System.Drawing.Size(103, 30);
            this.Usuarioent.TabIndex = 1;
            this.Usuarioent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usuarioent_KeyPress);
            // 
            // Contrasenaent
            // 
            this.Contrasenaent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenaent.Location = new System.Drawing.Point(400, 111);
            this.Contrasenaent.Margin = new System.Windows.Forms.Padding(2);
            this.Contrasenaent.Name = "Contrasenaent";
            this.Contrasenaent.PasswordChar = '*';
            this.Contrasenaent.Size = new System.Drawing.Size(103, 30);
            this.Contrasenaent.TabIndex = 2;
            this.Contrasenaent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contrasenaent_KeyPress);
            // 
            // Entrarboton
            // 
            this.Entrarboton.Image = ((System.Drawing.Image)(resources.GetObject("Entrarboton.Image")));
            this.Entrarboton.Location = new System.Drawing.Point(256, 178);
            this.Entrarboton.Margin = new System.Windows.Forms.Padding(2);
            this.Entrarboton.Name = "Entrarboton";
            this.Entrarboton.Size = new System.Drawing.Size(102, 66);
            this.Entrarboton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Entrarboton.TabIndex = 4;
            this.Entrarboton.TabStop = false;
            this.Entrarboton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Salirboton
            // 
            this.Salirboton.Image = ((System.Drawing.Image)(resources.GetObject("Salirboton.Image")));
            this.Salirboton.Location = new System.Drawing.Point(401, 178);
            this.Salirboton.Margin = new System.Windows.Forms.Padding(2);
            this.Salirboton.Name = "Salirboton";
            this.Salirboton.Size = new System.Drawing.Size(102, 66);
            this.Salirboton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salirboton.TabIndex = 5;
            this.Salirboton.TabStop = false;
            this.Salirboton.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(218, 218);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Salirboton);
            this.Controls.Add(this.Entrarboton);
            this.Controls.Add(this.Contrasenaent);
            this.Controls.Add(this.Usuarioent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada al sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Entrarboton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salirboton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Usuarioent;
        private System.Windows.Forms.TextBox Contrasenaent;
        private System.Windows.Forms.PictureBox Entrarboton;
        private System.Windows.Forms.PictureBox Salirboton;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

