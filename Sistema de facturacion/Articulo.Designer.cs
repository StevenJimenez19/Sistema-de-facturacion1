
namespace Sistema_de_facturacion
{
    partial class Articulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulo));
            this.Codigoarticulo = new System.Windows.Forms.Label();
            this.Codigoart = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Costoart = new System.Windows.Forms.TextBox();
            this.Descripcionart = new System.Windows.Forms.TextBox();
            this.Precioart = new System.Windows.Forms.TextBox();
            this.Cantidadart = new System.Windows.Forms.TextBox();
            this.Existenciaart = new System.Windows.Forms.TextBox();
            this.Cantidadminimaart = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Modificarart = new System.Windows.Forms.PictureBox();
            this.Eliminarart = new System.Windows.Forms.PictureBox();
            this.Imprimirartuculo = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Busquedaart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalart = new System.Windows.Forms.TextBox();
            this.acart = new System.Windows.Forms.DataGridView();
            this.codartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exiartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new Sistema_de_facturacion.FacturacionDataSet();
            this.articuloTableAdapter = new Sistema_de_facturacion.FacturacionDataSetTableAdapters.ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modificarart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminarart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imprimirartuculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigoarticulo
            // 
            this.Codigoarticulo.AutoSize = true;
            this.Codigoarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigoarticulo.Location = new System.Drawing.Point(79, 51);
            this.Codigoarticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Codigoarticulo.Name = "Codigoarticulo";
            this.Codigoarticulo.Size = new System.Drawing.Size(81, 25);
            this.Codigoarticulo.TabIndex = 0;
            this.Codigoarticulo.Text = "Codigo";
            // 
            // Codigoart
            // 
            this.Codigoart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigoart.Location = new System.Drawing.Point(178, 48);
            this.Codigoart.Margin = new System.Windows.Forms.Padding(2);
            this.Codigoart.Name = "Codigoart";
            this.Codigoart.Size = new System.Drawing.Size(149, 30);
            this.Codigoart.TabIndex = 10;
            this.Codigoart.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Codigoart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigoart_KeyPress);
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(11, 87);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(150, 25);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripcion(*)";
            this.Descripcion.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Costo(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Can. Minima";
            // 
            // Costoart
            // 
            this.Costoart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Costoart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costoart.Location = new System.Drawing.Point(178, 131);
            this.Costoart.Margin = new System.Windows.Forms.Padding(2);
            this.Costoart.Name = "Costoart";
            this.Costoart.Size = new System.Drawing.Size(113, 30);
            this.Costoart.TabIndex = 2;
            this.Costoart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costoart_KeyPress);
            // 
            // Descripcionart
            // 
            this.Descripcionart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Descripcionart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionart.Location = new System.Drawing.Point(178, 87);
            this.Descripcionart.Margin = new System.Windows.Forms.Padding(2);
            this.Descripcionart.Name = "Descripcionart";
            this.Descripcionart.Size = new System.Drawing.Size(217, 30);
            this.Descripcionart.TabIndex = 1;
            this.Descripcionart.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Descripcionart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Descripcionart_KeyPress);
            // 
            // Precioart
            // 
            this.Precioart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Precioart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precioart.Location = new System.Drawing.Point(178, 171);
            this.Precioart.Margin = new System.Windows.Forms.Padding(2);
            this.Precioart.Name = "Precioart";
            this.Precioart.Size = new System.Drawing.Size(113, 30);
            this.Precioart.TabIndex = 3;
            this.Precioart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precioart_KeyPress);
            // 
            // Cantidadart
            // 
            this.Cantidadart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cantidadart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidadart.Location = new System.Drawing.Point(178, 210);
            this.Cantidadart.Margin = new System.Windows.Forms.Padding(2);
            this.Cantidadart.Name = "Cantidadart";
            this.Cantidadart.Size = new System.Drawing.Size(113, 30);
            this.Cantidadart.TabIndex = 4;
            this.Cantidadart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidadart_KeyPress);
            // 
            // Existenciaart
            // 
            this.Existenciaart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Existenciaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existenciaart.Location = new System.Drawing.Point(178, 248);
            this.Existenciaart.Margin = new System.Windows.Forms.Padding(2);
            this.Existenciaart.Name = "Existenciaart";
            this.Existenciaart.Size = new System.Drawing.Size(113, 30);
            this.Existenciaart.TabIndex = 5;
            this.Existenciaart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Existenciaart_KeyPress);
            // 
            // Cantidadminimaart
            // 
            this.Cantidadminimaart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cantidadminimaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidadminimaart.Location = new System.Drawing.Point(178, 291);
            this.Cantidadminimaart.Margin = new System.Windows.Forms.Padding(2);
            this.Cantidadminimaart.Name = "Cantidadminimaart";
            this.Cantidadminimaart.Size = new System.Drawing.Size(113, 30);
            this.Cantidadminimaart.TabIndex = 6;
            this.Cantidadminimaart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidadminimaart_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(209, 416);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(112, 416);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Modificarart
            // 
            this.Modificarart.Image = ((System.Drawing.Image)(resources.GetObject("Modificarart.Image")));
            this.Modificarart.Location = new System.Drawing.Point(308, 416);
            this.Modificarart.Margin = new System.Windows.Forms.Padding(2);
            this.Modificarart.Name = "Modificarart";
            this.Modificarart.Size = new System.Drawing.Size(81, 62);
            this.Modificarart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Modificarart.TabIndex = 16;
            this.Modificarart.TabStop = false;
            this.Modificarart.Click += new System.EventHandler(this.Modificarart_Click);
            // 
            // Eliminarart
            // 
            this.Eliminarart.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarart.Image")));
            this.Eliminarart.Location = new System.Drawing.Point(415, 416);
            this.Eliminarart.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarart.Name = "Eliminarart";
            this.Eliminarart.Size = new System.Drawing.Size(81, 62);
            this.Eliminarart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eliminarart.TabIndex = 17;
            this.Eliminarart.TabStop = false;
            this.Eliminarart.Click += new System.EventHandler(this.Eliminarart_Click);
            // 
            // Imprimirartuculo
            // 
            this.Imprimirartuculo.Image = ((System.Drawing.Image)(resources.GetObject("Imprimirartuculo.Image")));
            this.Imprimirartuculo.Location = new System.Drawing.Point(520, 416);
            this.Imprimirartuculo.Margin = new System.Windows.Forms.Padding(2);
            this.Imprimirartuculo.Name = "Imprimirartuculo";
            this.Imprimirartuculo.Size = new System.Drawing.Size(81, 62);
            this.Imprimirartuculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Imprimirartuculo.TabIndex = 18;
            this.Imprimirartuculo.TabStop = false;
            this.Imprimirartuculo.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(622, 416);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(81, 62);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(505, 44);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(72, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // Busquedaart
            // 
            this.Busquedaart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busquedaart.Location = new System.Drawing.Point(587, 44);
            this.Busquedaart.Margin = new System.Windows.Forms.Padding(2);
            this.Busquedaart.Name = "Busquedaart";
            this.Busquedaart.Size = new System.Drawing.Size(192, 30);
            this.Busquedaart.TabIndex = 21;
            this.Busquedaart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Busquedaart_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // totalart
            // 
            this.totalart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalart.Location = new System.Drawing.Point(505, 342);
            this.totalart.Margin = new System.Windows.Forms.Padding(2);
            this.totalart.Name = "totalart";
            this.totalart.Size = new System.Drawing.Size(113, 30);
            this.totalart.TabIndex = 24;
            // 
            // acart
            // 
            this.acart.AutoGenerateColumns = false;
            this.acart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.acart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.acart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codartDataGridViewTextBoxColumn,
            this.desartDataGridViewTextBoxColumn,
            this.cosartDataGridViewTextBoxColumn,
            this.preartDataGridViewTextBoxColumn,
            this.exiartDataGridViewTextBoxColumn,
            this.canminDataGridViewTextBoxColumn});
            this.acart.DataSource = this.articuloBindingSource;
            this.acart.Location = new System.Drawing.Point(415, 87);
            this.acart.Margin = new System.Windows.Forms.Padding(2);
            this.acart.Name = "acart";
            this.acart.RowHeadersWidth = 62;
            this.acart.RowTemplate.Height = 28;
            this.acart.Size = new System.Drawing.Size(443, 230);
            this.acart.TabIndex = 25;
            // 
            // codartDataGridViewTextBoxColumn
            // 
            this.codartDataGridViewTextBoxColumn.DataPropertyName = "Cod_art";
            this.codartDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codartDataGridViewTextBoxColumn.Name = "codartDataGridViewTextBoxColumn";
            // 
            // desartDataGridViewTextBoxColumn
            // 
            this.desartDataGridViewTextBoxColumn.DataPropertyName = "Des_art";
            this.desartDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.desartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.desartDataGridViewTextBoxColumn.Name = "desartDataGridViewTextBoxColumn";
            // 
            // cosartDataGridViewTextBoxColumn
            // 
            this.cosartDataGridViewTextBoxColumn.DataPropertyName = "Cos_art";
            this.cosartDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.cosartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cosartDataGridViewTextBoxColumn.Name = "cosartDataGridViewTextBoxColumn";
            // 
            // preartDataGridViewTextBoxColumn
            // 
            this.preartDataGridViewTextBoxColumn.DataPropertyName = "Pre_art";
            this.preartDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.preartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.preartDataGridViewTextBoxColumn.Name = "preartDataGridViewTextBoxColumn";
            // 
            // exiartDataGridViewTextBoxColumn
            // 
            this.exiartDataGridViewTextBoxColumn.DataPropertyName = "Exi_art";
            this.exiartDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.exiartDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.exiartDataGridViewTextBoxColumn.Name = "exiartDataGridViewTextBoxColumn";
            // 
            // canminDataGridViewTextBoxColumn
            // 
            this.canminDataGridViewTextBoxColumn.DataPropertyName = "Can_min";
            this.canminDataGridViewTextBoxColumn.HeaderText = "Cantidad minima";
            this.canminDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.canminDataGridViewTextBoxColumn.Name = "canminDataGridViewTextBoxColumn";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.facturacionDataSet;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 487);
            this.Controls.Add(this.acart);
            this.Controls.Add(this.totalart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Busquedaart);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Imprimirartuculo);
            this.Controls.Add(this.Eliminarart);
            this.Controls.Add(this.Modificarart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cantidadminimaart);
            this.Controls.Add(this.Existenciaart);
            this.Controls.Add(this.Cantidadart);
            this.Controls.Add(this.Precioart);
            this.Controls.Add(this.Descripcionart);
            this.Controls.Add(this.Costoart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Codigoart);
            this.Controls.Add(this.Codigoarticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Modificarart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Eliminarart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imprimirartuculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigoarticulo;
        private System.Windows.Forms.TextBox Codigoart;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Costoart;
        private System.Windows.Forms.TextBox Descripcionart;
        private System.Windows.Forms.TextBox Precioart;
        private System.Windows.Forms.TextBox Cantidadart;
        private System.Windows.Forms.TextBox Existenciaart;
        private System.Windows.Forms.TextBox Cantidadminimaart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Modificarart;
        private System.Windows.Forms.PictureBox Eliminarart;
        private System.Windows.Forms.PictureBox Imprimirartuculo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox Busquedaart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalart;
        private System.Windows.Forms.DataGridView acart;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private FacturacionDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exiartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canminDataGridViewTextBoxColumn;
    }
}