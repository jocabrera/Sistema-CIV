namespace CapaPresentacion
{
    partial class Interfaz_Venta_Autos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Venta_Autos));
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Recomendacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDeSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cilindros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTituloVentaAuto = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbRegistros = new System.Windows.Forms.Label();
            this.btnSalirVA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutos
            // 
            this.dgvAutos.AllowUserToAddRows = false;
            this.dgvAutos.AllowUserToDeleteRows = false;
            this.dgvAutos.AllowUserToOrderColumns = true;
            this.dgvAutos.AllowUserToResizeColumns = false;
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Recomendacion,
            this.CUA,
            this.Marca,
            this.Modelo,
            this.anio,
            this.Color,
            this.TipoDeAuto,
            this.NumeroDeSerie,
            this.Cilindros,
            this.FechaDeCompra});
            this.dgvAutos.Location = new System.Drawing.Point(12, 94);
            this.dgvAutos.MultiSelect = false;
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAutos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutos.Size = new System.Drawing.Size(1215, 517);
            this.dgvAutos.TabIndex = 0;
            this.dgvAutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutos_CellContentClick);
            // 
            // Seleccionar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = false;
            this.Seleccionar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 95;
            // 
            // Recomendacion
            // 
            this.Recomendacion.HeaderText = "Recomendación";
            this.Recomendacion.Name = "Recomendacion";
            this.Recomendacion.ReadOnly = true;
            this.Recomendacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Recomendacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Recomendacion.Width = 120;
            // 
            // CUA
            // 
            this.CUA.DataPropertyName = "claveUnicaAuto";
            this.CUA.HeaderText = "CUA";
            this.CUA.Name = "CUA";
            this.CUA.ReadOnly = true;
            this.CUA.Width = 50;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 97;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 110;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 70;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // TipoDeAuto
            // 
            this.TipoDeAuto.DataPropertyName = "tipoAuto";
            this.TipoDeAuto.HeaderText = "Tipo de auto";
            this.TipoDeAuto.Name = "TipoDeAuto";
            this.TipoDeAuto.ReadOnly = true;
            this.TipoDeAuto.Width = 120;
            // 
            // NumeroDeSerie
            // 
            this.NumeroDeSerie.DataPropertyName = "numeroSerie";
            this.NumeroDeSerie.HeaderText = "Numero de serie";
            this.NumeroDeSerie.Name = "NumeroDeSerie";
            this.NumeroDeSerie.ReadOnly = true;
            this.NumeroDeSerie.Width = 155;
            // 
            // Cilindros
            // 
            this.Cilindros.DataPropertyName = "cantidadCilindros";
            this.Cilindros.HeaderText = "Cilindros";
            this.Cilindros.Name = "Cilindros";
            this.Cilindros.ReadOnly = true;
            this.Cilindros.Width = 110;
            // 
            // FechaDeCompra
            // 
            this.FechaDeCompra.DataPropertyName = "fechaCompra";
            this.FechaDeCompra.HeaderText = "Fecha de compra";
            this.FechaDeCompra.Name = "FechaDeCompra";
            this.FechaDeCompra.ReadOnly = true;
            this.FechaDeCompra.Width = 145;
            // 
            // lbTituloVentaAuto
            // 
            this.lbTituloVentaAuto.AutoSize = true;
            this.lbTituloVentaAuto.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloVentaAuto.ForeColor = System.Drawing.Color.Maroon;
            this.lbTituloVentaAuto.Location = new System.Drawing.Point(12, 54);
            this.lbTituloVentaAuto.Name = "lbTituloVentaAuto";
            this.lbTituloVentaAuto.Size = new System.Drawing.Size(186, 26);
            this.lbTituloVentaAuto.TabIndex = 1;
            this.lbTituloVentaAuto.Text = "Venta de Autos";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(29, 644);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(135, 20);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "TOTAL:       $";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtbxTotal.Location = new System.Drawing.Point(170, 644);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(143, 23);
            this.txtbxTotal.TabIndex = 3;
            this.txtbxTotal.TextChanged += new System.EventHandler(this.txtbxTotal_TextChanged);
            this.txtbxTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxTotal_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(1044, 630);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(183, 48);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(837, 630);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(185, 48);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbRegistros
            // 
            this.lbRegistros.AutoSize = true;
            this.lbRegistros.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistros.Location = new System.Drawing.Point(1017, 62);
            this.lbRegistros.Name = "lbRegistros";
            this.lbRegistros.Size = new System.Drawing.Size(186, 19);
            this.lbRegistros.TabIndex = 6;
            this.lbRegistros.Text = "Total de Registros: 0";
            this.lbRegistros.Click += new System.EventHandler(this.lbRegistros_Click);
            // 
            // btnSalirVA
            // 
            this.btnSalirVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalirVA.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirVA.Location = new System.Drawing.Point(1131, 17);
            this.btnSalirVA.Name = "btnSalirVA";
            this.btnSalirVA.Size = new System.Drawing.Size(96, 31);
            this.btnSalirVA.TabIndex = 7;
            this.btnSalirVA.Text = "Salir";
            this.btnSalirVA.UseVisualStyleBackColor = false;
            this.btnSalirVA.Click += new System.EventHandler(this.btnSalirVA_Click);
            // 
            // Interfaz_Venta_Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 690);
            this.Controls.Add(this.btnSalirVA);
            this.Controls.Add(this.lbRegistros);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbTituloVentaAuto);
            this.Controls.Add(this.dgvAutos);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Interfaz_Venta_Autos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Venta de Autos -Yonke Magaña :.";
            this.Load += new System.EventHandler(this.FrmVentaAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.Label lbTituloVentaAuto;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbRegistros;
        private System.Windows.Forms.Button btnSalirVA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recomendacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cilindros;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeCompra;
        private System.Windows.Forms.TextBox txtbxTotal;
    }
}