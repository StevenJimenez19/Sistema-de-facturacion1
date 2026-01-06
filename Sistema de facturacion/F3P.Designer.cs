
namespace Sistema_de_facturacion
{
    partial class F3P
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
            this.Numero = new System.Windows.Forms.TextBox();
            this.CRV3P = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.V3R2 = new Sistema_de_facturacion.V3R();
            this.V3R1 = new Sistema_de_facturacion.V3R();
            this.SuspendLayout();
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(343, 30);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(100, 20);
            this.Numero.TabIndex = 1;
            // 
            // CRV3P
            // 
            this.CRV3P.ActiveViewIndex = 0;
            this.CRV3P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV3P.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV3P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV3P.Location = new System.Drawing.Point(0, 0);
            this.CRV3P.Name = "CRV3P";
            this.CRV3P.ReportSource = this.V3R1;
            this.CRV3P.Size = new System.Drawing.Size(800, 450);
            this.CRV3P.TabIndex = 0;
            this.CRV3P.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // F3P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.CRV3P);
            this.Name = "F3P";
            this.Text = "F3P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV3P;
        private V3R V3R1;
        private V3R V3R2;
        public System.Windows.Forms.TextBox Numero;
    }
}