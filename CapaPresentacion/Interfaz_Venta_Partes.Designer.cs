namespace CapaPresentacion
{
    partial class Interfaz_Venta_Partes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Venta_Partes));
            this.btnSalirVP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbAI = new System.Windows.Forms.Label();
            this.lbAF = new System.Windows.Forms.Label();
            this.lbTipoAuto = new System.Windows.Forms.Label();
            this.lbCantCilindros = new System.Windows.Forms.Label();
            this.cmbMarcaAutoVenta = new System.Windows.Forms.ComboBox();
            this.cmbModeloAutoVenta = new System.Windows.Forms.ComboBox();
            this.cmbAIVenta = new System.Windows.Forms.ComboBox();
            this.cmbAFVenta = new System.Windows.Forms.ComboBox();
            this.cmbTipoAutoVenta = new System.Windows.Forms.ComboBox();
            this.cmbCilindrosVenta = new System.Windows.Forms.ComboBox();
            this.btnAceptarVta = new System.Windows.Forms.Button();
            this.dgvConsultaAutoVenta = new System.Windows.Forms.DataGridView();
            this.CUAVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAutoVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadCilindros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAccionVenta = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvConsultaPartesVenta = new System.Windows.Forms.DataGridView();
            this.Id_itemVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUAPartes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParteVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CondicionVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkbxAccionVenta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lbFolioCotizacion = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.txtbxFolio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAutoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPartesVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirVP
            // 
            this.btnSalirVP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalirVP.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirVP.Location = new System.Drawing.Point(1131, 16);
            this.btnSalirVP.Name = "btnSalirVP";
            this.btnSalirVP.Size = new System.Drawing.Size(96, 29);
            this.btnSalirVP.TabIndex = 0;
            this.btnSalirVP.Text = "Salir";
            this.btnSalirVP.UseVisualStyleBackColor = false;
            this.btnSalirVP.Click += new System.EventHandler(this.btnSalirVP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Venta de partes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione los siguientes datos del auto:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(60, 94);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(12);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(54, 16);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelo.Location = new System.Drawing.Point(60, 134);
            this.lbModelo.Margin = new System.Windows.Forms.Padding(12);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(54, 16);
            this.lbModelo.TabIndex = 4;
            this.lbModelo.Text = "Modelo";
            // 
            // lbAI
            // 
            this.lbAI.AutoSize = true;
            this.lbAI.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAI.Location = new System.Drawing.Point(60, 174);
            this.lbAI.Margin = new System.Windows.Forms.Padding(12);
            this.lbAI.Name = "lbAI";
            this.lbAI.Size = new System.Drawing.Size(80, 16);
            this.lbAI.TabIndex = 5;
            this.lbAI.Text = "Año inicial:";
            // 
            // lbAF
            // 
            this.lbAF.AutoSize = true;
            this.lbAF.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAF.Location = new System.Drawing.Point(60, 214);
            this.lbAF.Margin = new System.Windows.Forms.Padding(12);
            this.lbAF.Name = "lbAF";
            this.lbAF.Size = new System.Drawing.Size(71, 16);
            this.lbAF.TabIndex = 6;
            this.lbAF.Text = "Año final:";
            // 
            // lbTipoAuto
            // 
            this.lbTipoAuto.AutoSize = true;
            this.lbTipoAuto.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoAuto.Location = new System.Drawing.Point(60, 254);
            this.lbTipoAuto.Margin = new System.Windows.Forms.Padding(12);
            this.lbTipoAuto.Name = "lbTipoAuto";
            this.lbTipoAuto.Size = new System.Drawing.Size(98, 16);
            this.lbTipoAuto.TabIndex = 7;
            this.lbTipoAuto.Text = "Tipo de auto:";
            // 
            // lbCantCilindros
            // 
            this.lbCantCilindros.AutoSize = true;
            this.lbCantCilindros.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantCilindros.Location = new System.Drawing.Point(60, 294);
            this.lbCantCilindros.Margin = new System.Windows.Forms.Padding(12);
            this.lbCantCilindros.Name = "lbCantCilindros";
            this.lbCantCilindros.Size = new System.Drawing.Size(68, 16);
            this.lbCantCilindros.TabIndex = 8;
            this.lbCantCilindros.Text = "Cilindros:";
            // 
            // cmbMarcaAutoVenta
            // 
            this.cmbMarcaAutoVenta.DisplayMember = "marca";
            this.cmbMarcaAutoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaAutoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarcaAutoVenta.FormattingEnabled = true;
            this.cmbMarcaAutoVenta.Location = new System.Drawing.Point(178, 93);
            this.cmbMarcaAutoVenta.Name = "cmbMarcaAutoVenta";
            this.cmbMarcaAutoVenta.Size = new System.Drawing.Size(191, 23);
            this.cmbMarcaAutoVenta.TabIndex = 9;
            this.cmbMarcaAutoVenta.ValueMember = "id_marca";
            this.cmbMarcaAutoVenta.SelectedIndexChanged += new System.EventHandler(this.cmbMarcaAutoVenta_SelectedIndexChanged);
            // 
            // cmbModeloAutoVenta
            // 
            this.cmbModeloAutoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloAutoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModeloAutoVenta.FormattingEnabled = true;
            this.cmbModeloAutoVenta.Location = new System.Drawing.Point(178, 133);
            this.cmbModeloAutoVenta.Name = "cmbModeloAutoVenta";
            this.cmbModeloAutoVenta.Size = new System.Drawing.Size(191, 23);
            this.cmbModeloAutoVenta.TabIndex = 10;
            this.cmbModeloAutoVenta.SelectedIndexChanged += new System.EventHandler(this.cmbModeloAutoVenta_SelectedIndexChanged);
            // 
            // cmbAIVenta
            // 
            this.cmbAIVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAIVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAIVenta.FormattingEnabled = true;
            this.cmbAIVenta.Items.AddRange(new object[] {
            "",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cmbAIVenta.Location = new System.Drawing.Point(178, 173);
            this.cmbAIVenta.Name = "cmbAIVenta";
            this.cmbAIVenta.Size = new System.Drawing.Size(191, 23);
            this.cmbAIVenta.TabIndex = 11;
            // 
            // cmbAFVenta
            // 
            this.cmbAFVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAFVenta.FormattingEnabled = true;
            this.cmbAFVenta.Items.AddRange(new object[] {
            "",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.cmbAFVenta.Location = new System.Drawing.Point(178, 213);
            this.cmbAFVenta.Name = "cmbAFVenta";
            this.cmbAFVenta.Size = new System.Drawing.Size(191, 23);
            this.cmbAFVenta.TabIndex = 12;
            // 
            // cmbTipoAutoVenta
            // 
            this.cmbTipoAutoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAutoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAutoVenta.FormattingEnabled = true;
            this.cmbTipoAutoVenta.Items.AddRange(new object[] {
            "",
            "COUPE",
            "CONVERTIBLE",
            "HATCH BACK",
            "MINIVAN",
            "PICK UP",
            "SEDAN",
            "SUV"});
            this.cmbTipoAutoVenta.Location = new System.Drawing.Point(178, 253);
            this.cmbTipoAutoVenta.Name = "cmbTipoAutoVenta";
            this.cmbTipoAutoVenta.Size = new System.Drawing.Size(191, 23);
            this.cmbTipoAutoVenta.TabIndex = 13;
            // 
            // cmbCilindrosVenta
            // 
            this.cmbCilindrosVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCilindrosVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCilindrosVenta.FormattingEnabled = true;
            this.cmbCilindrosVenta.Items.AddRange(new object[] {
            "",
            "3 CILINDROS",
            "4 CILINDROS",
            "5 CILINDROS",
            "6 CILINDROS",
            "8 CILINDROS",
            "10 CILINDROS"});
            this.cmbCilindrosVenta.Location = new System.Drawing.Point(178, 293);
            this.cmbCilindrosVenta.Name = "cmbCilindrosVenta";
            this.cmbCilindrosVenta.Size = new System.Drawing.Size(191, 23);
            this.cmbCilindrosVenta.TabIndex = 14;
            // 
            // btnAceptarVta
            // 
            this.btnAceptarVta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAceptarVta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarVta.Location = new System.Drawing.Point(268, 326);
            this.btnAceptarVta.Margin = new System.Windows.Forms.Padding(9);
            this.btnAceptarVta.Name = "btnAceptarVta";
            this.btnAceptarVta.Size = new System.Drawing.Size(101, 30);
            this.btnAceptarVta.TabIndex = 15;
            this.btnAceptarVta.Text = "Aceptar";
            this.btnAceptarVta.UseVisualStyleBackColor = false;
            this.btnAceptarVta.Click += new System.EventHandler(this.btnAceptarVta_Click);
            // 
            // dgvConsultaAutoVenta
            // 
            this.dgvConsultaAutoVenta.AllowUserToAddRows = false;
            this.dgvConsultaAutoVenta.AllowUserToDeleteRows = false;
            this.dgvConsultaAutoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaAutoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUAVenta,
            this.marcaVenta,
            this.modeloVenta,
            this.anioVenta,
            this.colorVenta,
            this.tipoAutoVenta,
            this.cantidadCilindros,
            this.btnAccionVenta});
            this.dgvConsultaAutoVenta.Location = new System.Drawing.Point(391, 93);
            this.dgvConsultaAutoVenta.Name = "dgvConsultaAutoVenta";
            this.dgvConsultaAutoVenta.ReadOnly = true;
            this.dgvConsultaAutoVenta.Size = new System.Drawing.Size(813, 223);
            this.dgvConsultaAutoVenta.TabIndex = 16;
            this.dgvConsultaAutoVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentaDatosAuto_CellContentClick);
            // 
            // CUAVenta
            // 
            this.CUAVenta.DataPropertyName = "claveUnicaAuto";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.CUAVenta.DefaultCellStyle = dataGridViewCellStyle1;
            this.CUAVenta.HeaderText = "CUA";
            this.CUAVenta.Name = "CUAVenta";
            this.CUAVenta.ReadOnly = true;
            this.CUAVenta.Width = 60;
            // 
            // marcaVenta
            // 
            this.marcaVenta.DataPropertyName = "marca";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.marcaVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.marcaVenta.HeaderText = "Marca";
            this.marcaVenta.Name = "marcaVenta";
            this.marcaVenta.ReadOnly = true;
            this.marcaVenta.Width = 90;
            // 
            // modeloVenta
            // 
            this.modeloVenta.DataPropertyName = "modelo";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.modeloVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.modeloVenta.HeaderText = "Modelo";
            this.modeloVenta.Name = "modeloVenta";
            this.modeloVenta.ReadOnly = true;
            this.modeloVenta.Width = 90;
            // 
            // anioVenta
            // 
            this.anioVenta.DataPropertyName = "anio";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.anioVenta.DefaultCellStyle = dataGridViewCellStyle4;
            this.anioVenta.HeaderText = "Año";
            this.anioVenta.Name = "anioVenta";
            this.anioVenta.ReadOnly = true;
            this.anioVenta.Width = 90;
            // 
            // colorVenta
            // 
            this.colorVenta.DataPropertyName = "color";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.colorVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.colorVenta.HeaderText = "Color";
            this.colorVenta.Name = "colorVenta";
            this.colorVenta.ReadOnly = true;
            this.colorVenta.Width = 90;
            // 
            // tipoAutoVenta
            // 
            this.tipoAutoVenta.DataPropertyName = "tipoAuto";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.tipoAutoVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.tipoAutoVenta.HeaderText = "Tipo de auto";
            this.tipoAutoVenta.Name = "tipoAutoVenta";
            this.tipoAutoVenta.ReadOnly = true;
            // 
            // cantidadCilindros
            // 
            this.cantidadCilindros.DataPropertyName = "cantidadCilindros";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.cantidadCilindros.DefaultCellStyle = dataGridViewCellStyle7;
            this.cantidadCilindros.HeaderText = "Cilindros";
            this.cantidadCilindros.Name = "cantidadCilindros";
            this.cantidadCilindros.ReadOnly = true;
            this.cantidadCilindros.Width = 110;
            // 
            // btnAccionVenta
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = "Consultar partes";
            this.btnAccionVenta.DefaultCellStyle = dataGridViewCellStyle8;
            this.btnAccionVenta.HeaderText = "Acción";
            this.btnAccionVenta.Name = "btnAccionVenta";
            this.btnAccionVenta.ReadOnly = true;
            this.btnAccionVenta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnAccionVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnAccionVenta.Text = "Consultar partes";
            this.btnAccionVenta.ToolTipText = "Consultar partes";
            this.btnAccionVenta.Width = 140;
            // 
            // dgvConsultaPartesVenta
            // 
            this.dgvConsultaPartesVenta.AllowUserToAddRows = false;
            this.dgvConsultaPartesVenta.AllowUserToDeleteRows = false;
            this.dgvConsultaPartesVenta.AllowUserToOrderColumns = true;
            this.dgvConsultaPartesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPartesVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_itemVenta,
            this.CUAPartes,
            this.ParteVenta,
            this.CondicionVenta,
            this.PrecioVenta,
            this.chkbxAccionVenta});
            this.dgvConsultaPartesVenta.Location = new System.Drawing.Point(63, 387);
            this.dgvConsultaPartesVenta.Name = "dgvConsultaPartesVenta";
            this.dgvConsultaPartesVenta.Size = new System.Drawing.Size(1141, 242);
            this.dgvConsultaPartesVenta.TabIndex = 17;
            this.dgvConsultaPartesVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPartesVenta_CellContentClick);
            // 
            // Id_itemVenta
            // 
            this.Id_itemVenta.DataPropertyName = "Id_item";
            this.Id_itemVenta.HeaderText = "ID parte";
            this.Id_itemVenta.Name = "Id_itemVenta";
            this.Id_itemVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_itemVenta.Width = 90;
            // 
            // CUAPartes
            // 
            this.CUAPartes.DataPropertyName = "claveUnicaAuto";
            this.CUAPartes.HeaderText = "CUA";
            this.CUAPartes.Name = "CUAPartes";
            this.CUAPartes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CUAPartes.Visible = false;
            // 
            // ParteVenta
            // 
            this.ParteVenta.DataPropertyName = "Parte";
            this.ParteVenta.HeaderText = "Parte";
            this.ParteVenta.Name = "ParteVenta";
            this.ParteVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ParteVenta.Width = 330;
            // 
            // CondicionVenta
            // 
            this.CondicionVenta.DataPropertyName = "Condicion";
            this.CondicionVenta.HeaderText = "Condicion";
            this.CondicionVenta.Name = "CondicionVenta";
            this.CondicionVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CondicionVenta.Width = 235;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "Precio";
            this.PrecioVenta.HeaderText = "Precio MX$";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecioVenta.Width = 222;
            // 
            // chkbxAccionVenta
            // 
            this.chkbxAccionVenta.HeaderText = "Seleccionar para venta";
            this.chkbxAccionVenta.Name = "chkbxAccionVenta";
            this.chkbxAccionVenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkbxAccionVenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkbxAccionVenta.Width = 221;
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCotizar.Enabled = false;
            this.btnCotizar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(565, 635);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(111, 46);
            this.btnCotizar.TabIndex = 18;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lbFolioCotizacion
            // 
            this.lbFolioCotizacion.AutoSize = true;
            this.lbFolioCotizacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolioCotizacion.Location = new System.Drawing.Point(60, 652);
            this.lbFolioCotizacion.Name = "lbFolioCotizacion";
            this.lbFolioCotizacion.Size = new System.Drawing.Size(132, 16);
            this.lbFolioCotizacion.TabIndex = 19;
            this.lbFolioCotizacion.Text = "Folio de Cotización";
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAbrir.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(268, 643);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(78, 31);
            this.btnAbrir.TabIndex = 20;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // txtbxFolio
            // 
            this.txtbxFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtbxFolio.Location = new System.Drawing.Point(191, 648);
            this.txtbxFolio.Name = "txtbxFolio";
            this.txtbxFolio.Size = new System.Drawing.Size(71, 20);
            this.txtbxFolio.TabIndex = 21;
            this.txtbxFolio.TextChanged += new System.EventHandler(this.txtbxFolio_TextChanged);
            this.txtbxFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxfolio);
            // 
            // Interfaz_Venta_Partes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 690);
            this.Controls.Add(this.txtbxFolio);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lbFolioCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.dgvConsultaPartesVenta);
            this.Controls.Add(this.dgvConsultaAutoVenta);
            this.Controls.Add(this.btnAceptarVta);
            this.Controls.Add(this.cmbCilindrosVenta);
            this.Controls.Add(this.cmbTipoAutoVenta);
            this.Controls.Add(this.cmbAFVenta);
            this.Controls.Add(this.cmbAIVenta);
            this.Controls.Add(this.cmbModeloAutoVenta);
            this.Controls.Add(this.cmbMarcaAutoVenta);
            this.Controls.Add(this.lbCantCilindros);
            this.Controls.Add(this.lbTipoAuto);
            this.Controls.Add(this.lbAF);
            this.Controls.Add(this.lbAI);
            this.Controls.Add(this.lbModelo);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Interfaz_Venta_Partes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Venta de partes - Yonke Magaña:.";
            this.Load += new System.EventHandler(this.Interfaz_Venta_Partes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaAutoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPartesVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirVP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbAI;
        private System.Windows.Forms.Label lbAF;
        private System.Windows.Forms.Label lbTipoAuto;
        private System.Windows.Forms.Label lbCantCilindros;
        private System.Windows.Forms.ComboBox cmbMarcaAutoVenta;
        private System.Windows.Forms.ComboBox cmbModeloAutoVenta;
        private System.Windows.Forms.ComboBox cmbAIVenta;
        private System.Windows.Forms.ComboBox cmbAFVenta;
        private System.Windows.Forms.ComboBox cmbTipoAutoVenta;
        private System.Windows.Forms.ComboBox cmbCilindrosVenta;
        private System.Windows.Forms.Button btnAceptarVta;
        private System.Windows.Forms.DataGridView dgvConsultaAutoVenta;
        private System.Windows.Forms.DataGridView dgvConsultaPartesVenta;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUAVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAutoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadCilindros;
        private System.Windows.Forms.DataGridViewButtonColumn btnAccionVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_itemVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUAPartes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CondicionVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkbxAccionVenta;
        private System.Windows.Forms.Label lbFolioCotizacion;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.TextBox txtbxFolio;
    }
}