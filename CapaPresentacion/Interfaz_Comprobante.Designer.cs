namespace CapaPresentacion
{
    partial class Interfaz_Comprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Comprobante));
            this.lbNombreYonkeMagana = new System.Windows.Forms.Label();
            this.lbTextoCotizacion = new System.Windows.Forms.Label();
            this.pnlCotizacion = new System.Windows.Forms.Panel();
            this.ckbxGuardarCotizacion = new System.Windows.Forms.CheckBox();
            this.lbAhorroCotizacion = new System.Windows.Forms.Label();
            this.lbTotalPagarCotizacion = new System.Windows.Forms.Label();
            this.lbDescuentoCotizacion = new System.Windows.Forms.Label();
            this.lbTotalCotizacion = new System.Windows.Forms.Label();
            this.lbAhorro = new System.Windows.Forms.Label();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.lbDescuento = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbGracias = new System.Windows.Forms.Label();
            this.dgvConsultaCotizacion = new System.Windows.Forms.DataGridView();
            this.Id_itemCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCotizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbxClienteCotizacion = new System.Windows.Forms.TextBox();
            this.lbCliente = new System.Windows.Forms.Label();
            this.btnValidarCotizacion = new System.Windows.Forms.Button();
            this.txtbxCUCCotizacion = new System.Windows.Forms.TextBox();
            this.lbCUC = new System.Windows.Forms.Label();
            this.ckbxClienteCotizacion = new System.Windows.Forms.CheckBox();
            this.lbEncargadoYonke = new System.Windows.Forms.Label();
            this.lbDirYonke = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbTelYonke = new System.Windows.Forms.Label();
            this.lbCiudadYonke = new System.Windows.Forms.Label();
            this.lbRFCYonke = new System.Windows.Forms.Label();
            this.lbEncargado = new System.Windows.Forms.Label();
            this.lbDir = new System.Windows.Forms.Label();
            this.lbFech = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbCiudad = new System.Windows.Forms.Label();
            this.lbRFC = new System.Windows.Forms.Label();
            this.lbRecibido = new System.Windows.Forms.Label();
            this.txtbxRecibidoCotizacion = new System.Windows.Forms.TextBox();
            this.btnCobrarCotizacion = new System.Windows.Forms.Button();
            this.lbCambio = new System.Windows.Forms.Label();
            this.txtbxCambioCotizacion = new System.Windows.Forms.TextBox();
            this.btnImprimirCotizacion = new System.Windows.Forms.Button();
            this.brnRegresarCotizacion = new System.Windows.Forms.Button();
            this.pnlCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombreYonkeMagana
            // 
            this.lbNombreYonkeMagana.AutoSize = true;
            this.lbNombreYonkeMagana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreYonkeMagana.Location = new System.Drawing.Point(288, 21);
            this.lbNombreYonkeMagana.Name = "lbNombreYonkeMagana";
            this.lbNombreYonkeMagana.Size = new System.Drawing.Size(207, 31);
            this.lbNombreYonkeMagana.TabIndex = 0;
            this.lbNombreYonkeMagana.Text = "Yonke Magaña";
            // 
            // lbTextoCotizacion
            // 
            this.lbTextoCotizacion.AutoSize = true;
            this.lbTextoCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoCotizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTextoCotizacion.Location = new System.Drawing.Point(342, 61);
            this.lbTextoCotizacion.Name = "lbTextoCotizacion";
            this.lbTextoCotizacion.Size = new System.Drawing.Size(93, 20);
            this.lbTextoCotizacion.TabIndex = 1;
            this.lbTextoCotizacion.Text = "Cotización";
            // 
            // pnlCotizacion
            // 
            this.pnlCotizacion.BackColor = System.Drawing.Color.White;
            this.pnlCotizacion.Controls.Add(this.ckbxGuardarCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbAhorroCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbTotalPagarCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbDescuentoCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbTotalCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbAhorro);
            this.pnlCotizacion.Controls.Add(this.lbTotalPagar);
            this.pnlCotizacion.Controls.Add(this.lbDescuento);
            this.pnlCotizacion.Controls.Add(this.lbTotal);
            this.pnlCotizacion.Controls.Add(this.lbGracias);
            this.pnlCotizacion.Controls.Add(this.dgvConsultaCotizacion);
            this.pnlCotizacion.Controls.Add(this.txtbxClienteCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbCliente);
            this.pnlCotizacion.Controls.Add(this.btnValidarCotizacion);
            this.pnlCotizacion.Controls.Add(this.txtbxCUCCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbCUC);
            this.pnlCotizacion.Controls.Add(this.ckbxClienteCotizacion);
            this.pnlCotizacion.Controls.Add(this.lbEncargadoYonke);
            this.pnlCotizacion.Controls.Add(this.lbDirYonke);
            this.pnlCotizacion.Controls.Add(this.lbFecha);
            this.pnlCotizacion.Controls.Add(this.lbTelYonke);
            this.pnlCotizacion.Controls.Add(this.lbCiudadYonke);
            this.pnlCotizacion.Controls.Add(this.lbRFCYonke);
            this.pnlCotizacion.Controls.Add(this.lbEncargado);
            this.pnlCotizacion.Controls.Add(this.lbDir);
            this.pnlCotizacion.Controls.Add(this.lbFech);
            this.pnlCotizacion.Controls.Add(this.lbTel);
            this.pnlCotizacion.Controls.Add(this.lbCiudad);
            this.pnlCotizacion.Controls.Add(this.lbRFC);
            this.pnlCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCotizacion.Location = new System.Drawing.Point(39, 96);
            this.pnlCotizacion.Margin = new System.Windows.Forms.Padding(30);
            this.pnlCotizacion.Name = "pnlCotizacion";
            this.pnlCotizacion.Size = new System.Drawing.Size(706, 485);
            this.pnlCotizacion.TabIndex = 2;
            // 
            // ckbxGuardarCotizacion
            // 
            this.ckbxGuardarCotizacion.AutoSize = true;
            this.ckbxGuardarCotizacion.Location = new System.Drawing.Point(24, 393);
            this.ckbxGuardarCotizacion.Name = "ckbxGuardarCotizacion";
            this.ckbxGuardarCotizacion.Size = new System.Drawing.Size(145, 19);
            this.ckbxGuardarCotizacion.TabIndex = 28;
            this.ckbxGuardarCotizacion.Text = "¿Guardar Cotización?";
            this.ckbxGuardarCotizacion.UseVisualStyleBackColor = true;
            // 
            // lbAhorroCotizacion
            // 
            this.lbAhorroCotizacion.AutoSize = true;
            this.lbAhorroCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAhorroCotizacion.ForeColor = System.Drawing.Color.Red;
            this.lbAhorroCotizacion.Location = new System.Drawing.Point(529, 450);
            this.lbAhorroCotizacion.Name = "lbAhorroCotizacion";
            this.lbAhorroCotizacion.Size = new System.Drawing.Size(59, 20);
            this.lbAhorroCotizacion.TabIndex = 27;
            this.lbAhorroCotizacion.Text = "dinero";
            // 
            // lbTotalPagarCotizacion
            // 
            this.lbTotalPagarCotizacion.AutoSize = true;
            this.lbTotalPagarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagarCotizacion.Location = new System.Drawing.Point(529, 420);
            this.lbTotalPagarCotizacion.Name = "lbTotalPagarCotizacion";
            this.lbTotalPagarCotizacion.Size = new System.Drawing.Size(59, 20);
            this.lbTotalPagarCotizacion.TabIndex = 26;
            this.lbTotalPagarCotizacion.Text = "dinero";
            // 
            // lbDescuentoCotizacion
            // 
            this.lbDescuentoCotizacion.AutoSize = true;
            this.lbDescuentoCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuentoCotizacion.ForeColor = System.Drawing.Color.Lime;
            this.lbDescuentoCotizacion.Location = new System.Drawing.Point(529, 390);
            this.lbDescuentoCotizacion.Name = "lbDescuentoCotizacion";
            this.lbDescuentoCotizacion.Size = new System.Drawing.Size(59, 20);
            this.lbDescuentoCotizacion.TabIndex = 25;
            this.lbDescuentoCotizacion.Text = "dinero";
            // 
            // lbTotalCotizacion
            // 
            this.lbTotalCotizacion.AutoSize = true;
            this.lbTotalCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCotizacion.Location = new System.Drawing.Point(529, 360);
            this.lbTotalCotizacion.Name = "lbTotalCotizacion";
            this.lbTotalCotizacion.Size = new System.Drawing.Size(59, 20);
            this.lbTotalCotizacion.TabIndex = 24;
            this.lbTotalCotizacion.Text = "dinero";
            // 
            // lbAhorro
            // 
            this.lbAhorro.AutoSize = true;
            this.lbAhorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAhorro.Location = new System.Drawing.Point(385, 452);
            this.lbAhorro.Margin = new System.Windows.Forms.Padding(6);
            this.lbAhorro.Name = "lbAhorro";
            this.lbAhorro.Size = new System.Drawing.Size(112, 18);
            this.lbAhorro.TabIndex = 23;
            this.lbAhorro.Text = "Usted ahorro:";
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPagar.Location = new System.Drawing.Point(385, 422);
            this.lbTotalPagar.Margin = new System.Windows.Forms.Padding(6);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(112, 18);
            this.lbTotalPagar.TabIndex = 22;
            this.lbTotalPagar.Text = "Total a pagar:";
            // 
            // lbDescuento
            // 
            this.lbDescuento.AutoSize = true;
            this.lbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescuento.Location = new System.Drawing.Point(385, 392);
            this.lbDescuento.Margin = new System.Windows.Forms.Padding(6);
            this.lbDescuento.Name = "lbDescuento";
            this.lbDescuento.Size = new System.Drawing.Size(94, 18);
            this.lbDescuento.TabIndex = 21;
            this.lbDescuento.Text = "Descuento:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(385, 362);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(6);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(51, 18);
            this.lbTotal.TabIndex = 20;
            this.lbTotal.Text = "Total:";
            // 
            // lbGracias
            // 
            this.lbGracias.AutoSize = true;
            this.lbGracias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGracias.Location = new System.Drawing.Point(19, 357);
            this.lbGracias.Name = "lbGracias";
            this.lbGracias.Size = new System.Drawing.Size(257, 25);
            this.lbGracias.TabIndex = 19;
            this.lbGracias.Text = "Gracias por su compra!";
            // 
            // dgvConsultaCotizacion
            // 
            this.dgvConsultaCotizacion.AllowUserToAddRows = false;
            this.dgvConsultaCotizacion.AllowUserToDeleteRows = false;
            this.dgvConsultaCotizacion.AllowUserToResizeColumns = false;
            this.dgvConsultaCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_itemCotizacion,
            this.marcaCotizacion,
            this.modeloCotizacion,
            this.anioCotizacion,
            this.PrecioCotizacion});
            this.dgvConsultaCotizacion.Location = new System.Drawing.Point(24, 127);
            this.dgvConsultaCotizacion.Name = "dgvConsultaCotizacion";
            this.dgvConsultaCotizacion.ReadOnly = true;
            this.dgvConsultaCotizacion.Size = new System.Drawing.Size(666, 218);
            this.dgvConsultaCotizacion.TabIndex = 18;
            // 
            // Id_itemCotizacion
            // 
            this.Id_itemCotizacion.DataPropertyName = "Parte";
            this.Id_itemCotizacion.HeaderText = "Parte";
            this.Id_itemCotizacion.Name = "Id_itemCotizacion";
            this.Id_itemCotizacion.ReadOnly = true;
            this.Id_itemCotizacion.Width = 243;
            // 
            // marcaCotizacion
            // 
            this.marcaCotizacion.DataPropertyName = "marca";
            this.marcaCotizacion.HeaderText = "Marca";
            this.marcaCotizacion.Name = "marcaCotizacion";
            this.marcaCotizacion.ReadOnly = true;
            // 
            // modeloCotizacion
            // 
            this.modeloCotizacion.DataPropertyName = "modelo";
            this.modeloCotizacion.HeaderText = "Modelo";
            this.modeloCotizacion.Name = "modeloCotizacion";
            this.modeloCotizacion.ReadOnly = true;
            // 
            // anioCotizacion
            // 
            this.anioCotizacion.DataPropertyName = "anio";
            this.anioCotizacion.HeaderText = "Año";
            this.anioCotizacion.Name = "anioCotizacion";
            this.anioCotizacion.ReadOnly = true;
            this.anioCotizacion.Width = 80;
            // 
            // PrecioCotizacion
            // 
            this.PrecioCotizacion.DataPropertyName = "Precio";
            this.PrecioCotizacion.HeaderText = "Precio";
            this.PrecioCotizacion.Name = "PrecioCotizacion";
            this.PrecioCotizacion.ReadOnly = true;
            // 
            // txtbxClienteCotizacion
            // 
            this.txtbxClienteCotizacion.Location = new System.Drawing.Point(473, 98);
            this.txtbxClienteCotizacion.Name = "txtbxClienteCotizacion";
            this.txtbxClienteCotizacion.ReadOnly = true;
            this.txtbxClienteCotizacion.Size = new System.Drawing.Size(217, 21);
            this.txtbxClienteCotizacion.TabIndex = 17;
            this.txtbxClienteCotizacion.Visible = false;
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(400, 99);
            this.lbCliente.Margin = new System.Windows.Forms.Padding(7);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(56, 15);
            this.lbCliente.TabIndex = 16;
            this.lbCliente.Text = "Cliente:";
            this.lbCliente.Visible = false;
            // 
            // btnValidarCotizacion
            // 
            this.btnValidarCotizacion.Location = new System.Drawing.Point(308, 97);
            this.btnValidarCotizacion.Name = "btnValidarCotizacion";
            this.btnValidarCotizacion.Size = new System.Drawing.Size(64, 23);
            this.btnValidarCotizacion.TabIndex = 15;
            this.btnValidarCotizacion.Text = "Validar";
            this.btnValidarCotizacion.UseVisualStyleBackColor = true;
            this.btnValidarCotizacion.Visible = false;
            this.btnValidarCotizacion.Click += new System.EventHandler(this.btnValidarCotizacion_Click);
            // 
            // txtbxCUCCotizacion
            // 
            this.txtbxCUCCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtbxCUCCotizacion.Location = new System.Drawing.Point(206, 98);
            this.txtbxCUCCotizacion.Name = "txtbxCUCCotizacion";
            this.txtbxCUCCotizacion.Size = new System.Drawing.Size(94, 21);
            this.txtbxCUCCotizacion.TabIndex = 14;
            this.txtbxCUCCotizacion.Visible = false;
            this.txtbxCUCCotizacion.TextChanged += new System.EventHandler(this.txtbxCUCCotizacion_TextChanged);
            this.txtbxCUCCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbCUC
            // 
            this.lbCUC.AutoSize = true;
            this.lbCUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUC.Location = new System.Drawing.Point(157, 99);
            this.lbCUC.Margin = new System.Windows.Forms.Padding(7);
            this.lbCUC.Name = "lbCUC";
            this.lbCUC.Size = new System.Drawing.Size(39, 15);
            this.lbCUC.TabIndex = 13;
            this.lbCUC.Text = "CUC:";
            this.lbCUC.Visible = false;
            // 
            // ckbxClienteCotizacion
            // 
            this.ckbxClienteCotizacion.AutoSize = true;
            this.ckbxClienteCotizacion.Location = new System.Drawing.Point(24, 98);
            this.ckbxClienteCotizacion.Margin = new System.Windows.Forms.Padding(7);
            this.ckbxClienteCotizacion.Name = "ckbxClienteCotizacion";
            this.ckbxClienteCotizacion.Size = new System.Drawing.Size(132, 19);
            this.ckbxClienteCotizacion.TabIndex = 12;
            this.ckbxClienteCotizacion.Text = "¿Cliente frecuente?";
            this.ckbxClienteCotizacion.UseVisualStyleBackColor = true;
            this.ckbxClienteCotizacion.CheckedChanged += new System.EventHandler(this.ckbxClienteCotizacion_CheckedChanged);
            this.ckbxClienteCotizacion.Click += new System.EventHandler(this.ckbxClienteCotizacion_Click);
            // 
            // lbEncargadoYonke
            // 
            this.lbEncargadoYonke.AutoSize = true;
            this.lbEncargadoYonke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncargadoYonke.Location = new System.Drawing.Point(555, 69);
            this.lbEncargadoYonke.Margin = new System.Windows.Forms.Padding(7);
            this.lbEncargadoYonke.Name = "lbEncargadoYonke";
            this.lbEncargadoYonke.Size = new System.Drawing.Size(135, 15);
            this.lbEncargadoYonke.TabIndex = 11;
            this.lbEncargadoYonke.Text = "Pablo Magaña Cabrera";
            // 
            // lbDirYonke
            // 
            this.lbDirYonke.AutoSize = true;
            this.lbDirYonke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirYonke.Location = new System.Drawing.Point(107, 69);
            this.lbDirYonke.Margin = new System.Windows.Forms.Padding(7);
            this.lbDirYonke.Name = "lbDirYonke";
            this.lbDirYonke.Size = new System.Drawing.Size(260, 15);
            this.lbDirYonke.TabIndex = 10;
            this.lbDirYonke.Text = "Avenida Zoraya #1838, Colonia Margaritas Sur";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(558, 40);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(7);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(0, 15);
            this.lbFecha.TabIndex = 9;
            // 
            // lbTelYonke
            // 
            this.lbTelYonke.AutoSize = true;
            this.lbTelYonke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelYonke.Location = new System.Drawing.Point(407, 40);
            this.lbTelYonke.Margin = new System.Windows.Forms.Padding(7);
            this.lbTelYonke.Name = "lbTelYonke";
            this.lbTelYonke.Size = new System.Drawing.Size(89, 15);
            this.lbTelYonke.TabIndex = 8;
            this.lbTelYonke.Text = "(686)552-1725";
            // 
            // lbCiudadYonke
            // 
            this.lbCiudadYonke.AutoSize = true;
            this.lbCiudadYonke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiudadYonke.Location = new System.Drawing.Point(248, 40);
            this.lbCiudadYonke.Margin = new System.Windows.Forms.Padding(7);
            this.lbCiudadYonke.Name = "lbCiudadYonke";
            this.lbCiudadYonke.Size = new System.Drawing.Size(75, 15);
            this.lbCiudadYonke.TabIndex = 7;
            this.lbCiudadYonke.Text = "Mexicali B.C";
            // 
            // lbRFCYonke
            // 
            this.lbRFCYonke.AutoSize = true;
            this.lbRFCYonke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFCYonke.Location = new System.Drawing.Point(73, 40);
            this.lbRFCYonke.Margin = new System.Windows.Forms.Padding(7);
            this.lbRFCYonke.Name = "lbRFCYonke";
            this.lbRFCYonke.Size = new System.Drawing.Size(104, 15);
            this.lbRFCYonke.TabIndex = 6;
            this.lbRFCYonke.Text = "CUPU800825569";
            // 
            // lbEncargado
            // 
            this.lbEncargado.AutoSize = true;
            this.lbEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncargado.Location = new System.Drawing.Point(461, 69);
            this.lbEncargado.Margin = new System.Windows.Forms.Padding(7);
            this.lbEncargado.Name = "lbEncargado";
            this.lbEncargado.Size = new System.Drawing.Size(80, 15);
            this.lbEncargado.TabIndex = 5;
            this.lbEncargado.Text = "Encargado:";
            // 
            // lbDir
            // 
            this.lbDir.AutoSize = true;
            this.lbDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDir.Location = new System.Drawing.Point(21, 69);
            this.lbDir.Margin = new System.Windows.Forms.Padding(7);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(72, 15);
            this.lbDir.TabIndex = 4;
            this.lbDir.Text = "Dirección:";
            // 
            // lbFech
            // 
            this.lbFech.AutoSize = true;
            this.lbFech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFech.Location = new System.Drawing.Point(508, 40);
            this.lbFech.Margin = new System.Windows.Forms.Padding(7);
            this.lbFech.Name = "lbFech";
            this.lbFech.Size = new System.Drawing.Size(50, 15);
            this.lbFech.TabIndex = 3;
            this.lbFech.Text = "Fecha:";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(334, 40);
            this.lbTel.Margin = new System.Windows.Forms.Padding(7);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(67, 15);
            this.lbTel.TabIndex = 2;
            this.lbTel.Text = "Teléfono:";
            // 
            // lbCiudad
            // 
            this.lbCiudad.AutoSize = true;
            this.lbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCiudad.Location = new System.Drawing.Point(186, 40);
            this.lbCiudad.Margin = new System.Windows.Forms.Padding(7);
            this.lbCiudad.Name = "lbCiudad";
            this.lbCiudad.Size = new System.Drawing.Size(56, 15);
            this.lbCiudad.TabIndex = 1;
            this.lbCiudad.Text = "Ciudad:";
            // 
            // lbRFC
            // 
            this.lbRFC.AutoSize = true;
            this.lbRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRFC.Location = new System.Drawing.Point(21, 40);
            this.lbRFC.Margin = new System.Windows.Forms.Padding(7);
            this.lbRFC.Name = "lbRFC";
            this.lbRFC.Size = new System.Drawing.Size(46, 15);
            this.lbRFC.TabIndex = 0;
            this.lbRFC.Text = "R.F.C:";
            // 
            // lbRecibido
            // 
            this.lbRecibido.AutoSize = true;
            this.lbRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecibido.Location = new System.Drawing.Point(60, 597);
            this.lbRecibido.Margin = new System.Windows.Forms.Padding(6);
            this.lbRecibido.Name = "lbRecibido";
            this.lbRecibido.Size = new System.Drawing.Size(79, 18);
            this.lbRecibido.TabIndex = 24;
            this.lbRecibido.Text = "Recibido:";
            // 
            // txtbxRecibidoCotizacion
            // 
            this.txtbxRecibidoCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtbxRecibidoCotizacion.Location = new System.Drawing.Point(140, 598);
            this.txtbxRecibidoCotizacion.Name = "txtbxRecibidoCotizacion";
            this.txtbxRecibidoCotizacion.Size = new System.Drawing.Size(118, 20);
            this.txtbxRecibidoCotizacion.TabIndex = 25;
            this.txtbxRecibidoCotizacion.TextChanged += new System.EventHandler(this.txtbxRecibidoCotizacion_TextChanged);
            this.txtbxRecibidoCotizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // btnCobrarCotizacion
            // 
            this.btnCobrarCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCobrarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrarCotizacion.Location = new System.Drawing.Point(277, 596);
            this.btnCobrarCotizacion.Name = "btnCobrarCotizacion";
            this.btnCobrarCotizacion.Size = new System.Drawing.Size(99, 55);
            this.btnCobrarCotizacion.TabIndex = 26;
            this.btnCobrarCotizacion.Text = "Cobrar ";
            this.btnCobrarCotizacion.UseVisualStyleBackColor = false;
            this.btnCobrarCotizacion.Click += new System.EventHandler(this.btnCobrarCotizacion_Click);
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCambio.Location = new System.Drawing.Point(60, 630);
            this.lbCambio.Margin = new System.Windows.Forms.Padding(6);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(71, 18);
            this.lbCambio.TabIndex = 27;
            this.lbCambio.Text = "Cambio:";
            // 
            // txtbxCambioCotizacion
            // 
            this.txtbxCambioCotizacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbxCambioCotizacion.Location = new System.Drawing.Point(140, 631);
            this.txtbxCambioCotizacion.Name = "txtbxCambioCotizacion";
            this.txtbxCambioCotizacion.ReadOnly = true;
            this.txtbxCambioCotizacion.Size = new System.Drawing.Size(118, 20);
            this.txtbxCambioCotizacion.TabIndex = 28;
            // 
            // btnImprimirCotizacion
            // 
            this.btnImprimirCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirCotizacion.Location = new System.Drawing.Point(630, 598);
            this.btnImprimirCotizacion.Name = "btnImprimirCotizacion";
            this.btnImprimirCotizacion.Size = new System.Drawing.Size(99, 53);
            this.btnImprimirCotizacion.TabIndex = 29;
            this.btnImprimirCotizacion.Text = "Imprimir comprobante";
            this.btnImprimirCotizacion.UseVisualStyleBackColor = true;
            this.btnImprimirCotizacion.Visible = false;
            this.btnImprimirCotizacion.Click += new System.EventHandler(this.btnImprimirCotizacion_Click);
            // 
            // brnRegresarCotizacion
            // 
            this.brnRegresarCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.brnRegresarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnRegresarCotizacion.Location = new System.Drawing.Point(388, 596);
            this.brnRegresarCotizacion.Name = "brnRegresarCotizacion";
            this.brnRegresarCotizacion.Size = new System.Drawing.Size(99, 55);
            this.brnRegresarCotizacion.TabIndex = 30;
            this.brnRegresarCotizacion.Text = "Regresar";
            this.brnRegresarCotizacion.UseVisualStyleBackColor = false;
            this.brnRegresarCotizacion.Click += new System.EventHandler(this.brnRegresarCotizacion_Click);
            // 
            // Interfaz_Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 714);
            this.Controls.Add(this.brnRegresarCotizacion);
            this.Controls.Add(this.btnImprimirCotizacion);
            this.Controls.Add(this.txtbxCambioCotizacion);
            this.Controls.Add(this.lbCambio);
            this.Controls.Add(this.btnCobrarCotizacion);
            this.Controls.Add(this.txtbxRecibidoCotizacion);
            this.Controls.Add(this.lbRecibido);
            this.Controls.Add(this.pnlCotizacion);
            this.Controls.Add(this.lbTextoCotizacion);
            this.Controls.Add(this.lbNombreYonkeMagana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Interfaz_Comprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Venta de partes - Yonke Magaña :. (Comprobante)";
            this.Load += new System.EventHandler(this.Interfaz_Comprobante_Load);
            this.pnlCotizacion.ResumeLayout(false);
            this.pnlCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombreYonkeMagana;
        private System.Windows.Forms.Label lbTextoCotizacion;
        private System.Windows.Forms.Panel pnlCotizacion;
        private System.Windows.Forms.DataGridView dgvConsultaCotizacion;
        private System.Windows.Forms.TextBox txtbxClienteCotizacion;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button btnValidarCotizacion;
        private System.Windows.Forms.TextBox txtbxCUCCotizacion;
        private System.Windows.Forms.Label lbCUC;
        private System.Windows.Forms.CheckBox ckbxClienteCotizacion;
        private System.Windows.Forms.Label lbEncargadoYonke;
        private System.Windows.Forms.Label lbDirYonke;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbTelYonke;
        private System.Windows.Forms.Label lbCiudadYonke;
        private System.Windows.Forms.Label lbRFCYonke;
        private System.Windows.Forms.Label lbEncargado;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.Label lbFech;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbCiudad;
        private System.Windows.Forms.Label lbRFC;
        private System.Windows.Forms.Label lbAhorro;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.Label lbDescuento;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbGracias;
        private System.Windows.Forms.Label lbRecibido;
        private System.Windows.Forms.TextBox txtbxRecibidoCotizacion;
        private System.Windows.Forms.Button btnCobrarCotizacion;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.TextBox txtbxCambioCotizacion;
        private System.Windows.Forms.Button btnImprimirCotizacion;
        private System.Windows.Forms.Label lbAhorroCotizacion;
        private System.Windows.Forms.Label lbTotalPagarCotizacion;
        private System.Windows.Forms.Label lbDescuentoCotizacion;
        private System.Windows.Forms.Label lbTotalCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_itemCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioCotizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCotizacion;
        private System.Windows.Forms.Button brnRegresarCotizacion;
        private System.Windows.Forms.CheckBox ckbxGuardarCotizacion;
    }
}