
namespace Sistema_de_facturacion
{
    partial class CxC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalCobrar = new System.Windows.Forms.Label();
            this.lblTextoTotal = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnRegistrarCobro = new System.Windows.Forms.Button();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.dgvCxC = new System.Windows.Forms.DataGridView();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alldatabase = new Sistema_de_facturacion.Alldatabase();
            this.lblTituloFactura = new System.Windows.Forms.Label();
            this.facturaTableAdapter = new Sistema_de_facturacion.AlldatabaseTableAdapters.FacturaTableAdapter();
            this.Numfac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_fac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalfactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTotalCobrar);
            this.panel1.Controls.Add(this.lblTextoTotal);
            this.panel1.Controls.Add(this.btnVerDetalle);
            this.panel1.Controls.Add(this.btnRegistrarCobro);
            this.panel1.Controls.Add(this.cmbFiltroEstado);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBuscarCliente);
            this.panel1.Controls.Add(this.dgvCxC);
            this.panel1.Controls.Add(this.lblTituloFactura);
            this.panel1.Location = new System.Drawing.Point(14, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 548);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalCobrar
            // 
            this.lblTotalCobrar.AutoSize = true;
            this.lblTotalCobrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCobrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTotalCobrar.Location = new System.Drawing.Point(495, 349);
            this.lblTotalCobrar.Name = "lblTotalCobrar";
            this.lblTotalCobrar.Size = new System.Drawing.Size(44, 16);
            this.lblTotalCobrar.TabIndex = 20;
            this.lblTotalCobrar.Text = "$ 0.00";
            // 
            // lblTextoTotal
            // 
            this.lblTextoTotal.AutoSize = true;
            this.lblTextoTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoTotal.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTextoTotal.Location = new System.Drawing.Point(375, 349);
            this.lblTextoTotal.Name = "lblTextoTotal";
            this.lblTextoTotal.Size = new System.Drawing.Size(115, 16);
            this.lblTextoTotal.TabIndex = 19;
            this.lblTextoTotal.Text = "Total por Cobrar:";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.SlateGray;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVerDetalle.Location = new System.Drawing.Point(198, 333);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(164, 44);
            this.btnVerDetalle.TabIndex = 18;
            this.btnVerDetalle.Text = "Ver Detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCobro
            // 
            this.btnRegistrarCobro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegistrarCobro.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCobro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCobro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarCobro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRegistrarCobro.Location = new System.Drawing.Point(18, 333);
            this.btnRegistrarCobro.Name = "btnRegistrarCobro";
            this.btnRegistrarCobro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrarCobro.Size = new System.Drawing.Size(164, 44);
            this.btnRegistrarCobro.TabIndex = 17;
            this.btnRegistrarCobro.Text = "Registrar Cobro";
            this.btnRegistrarCobro.UseVisualStyleBackColor = false;
            this.btnRegistrarCobro.Click += new System.EventHandler(this.btnRegistrarCobro_Click);
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.AccessibleDescription = "";
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(381, 61);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(159, 21);
            this.cmbFiltroEstado.TabIndex = 16;
            this.cmbFiltroEstado.Text = "Estado Pendiente";
            this.cmbFiltroEstado.TextChanged += new System.EventHandler(this.cmbFiltroEstado_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(18, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 1);
            this.panel2.TabIndex = 15;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(21, 61);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(197, 20);
            this.txtBuscarCliente.TabIndex = 14;
            this.txtBuscarCliente.Text = "Buscar Factura";
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // dgvCxC
            // 
            this.dgvCxC.AllowUserToDeleteRows = false;
            this.dgvCxC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCxC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numfac,
            this.Nom_cli,
            this.Fec_fac,
            this.Totalfactura,
            this.Estado});
            this.dgvCxC.Location = new System.Drawing.Point(18, 88);
            this.dgvCxC.Name = "dgvCxC";
            this.dgvCxC.Size = new System.Drawing.Size(543, 228);
            this.dgvCxC.TabIndex = 13;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.alldatabase;
            // 
            // alldatabase
            // 
            this.alldatabase.DataSetName = "Alldatabase";
            this.alldatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTituloFactura
            // 
            this.lblTituloFactura.AutoSize = true;
            this.lblTituloFactura.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFactura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTituloFactura.Location = new System.Drawing.Point(15, 13);
            this.lblTituloFactura.Name = "lblTituloFactura";
            this.lblTituloFactura.Size = new System.Drawing.Size(275, 32);
            this.lblTituloFactura.TabIndex = 1;
            this.lblTituloFactura.Text = "Cuentas por Cobrar";
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // Numfac
            // 
            this.Numfac.HeaderText = "Numero factura";
            this.Numfac.Name = "Numfac";
            // 
            // Nom_cli
            // 
            this.Nom_cli.DataPropertyName = "Nom_cli";
            this.Nom_cli.HeaderText = "Nombre Cliente";
            this.Nom_cli.Name = "Nom_cli";
            // 
            // Fec_fac
            // 
            this.Fec_fac.HeaderText = "Fecha factura";
            this.Fec_fac.Name = "Fec_fac";
            // 
            // Totalfactura
            // 
            this.Totalfactura.HeaderText = "TotalFactura";
            this.Totalfactura.Name = "Totalfactura";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // CxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 460);
            this.Controls.Add(this.panel1);
            this.Name = "CxC";
            this.Text = "Cuenta por Cobrar";
            this.Load += new System.EventHandler(this.CxC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alldatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloFactura;
        private System.Windows.Forms.DataGridView dgvCxC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnRegistrarCobro;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Label lblTotalCobrar;
        private System.Windows.Forms.Label lblTextoTotal;
        private Alldatabase alldatabase;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private AlldatabaseTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numfac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fec_fac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalfactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}


