namespace CapaPresentacion
{
    partial class Interfaz_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz_Principal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mantenimientoDeAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDePartesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaDeAutoschatarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImagenPrincipal = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeAutosToolStripMenuItem,
            this.ventaDePartesToolStripMenuItem,
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ventaDeAutoschatarraToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuPrincipal.Size = new System.Drawing.Size(1317, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mantenimientoDeAutosToolStripMenuItem
            // 
            this.mantenimientoDeAutosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDeAutosToolStripMenuItem.Image")));
            this.mantenimientoDeAutosToolStripMenuItem.Name = "mantenimientoDeAutosToolStripMenuItem";
            this.mantenimientoDeAutosToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.mantenimientoDeAutosToolStripMenuItem.Text = "Mantenimiento de autos";
            this.mantenimientoDeAutosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeAutosToolStripMenuItem_Click);
            // 
            // ventaDePartesToolStripMenuItem
            // 
            this.ventaDePartesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDePartesToolStripMenuItem.Image")));
            this.ventaDePartesToolStripMenuItem.Name = "ventaDePartesToolStripMenuItem";
            this.ventaDePartesToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.ventaDePartesToolStripMenuItem.Text = "Venta de partes";
            this.ventaDePartesToolStripMenuItem.Click += new System.EventHandler(this.ventaDePartesToolStripMenuItem_Click);
            // 
            // mantenimientoDeClientesFrecuentesToolStripMenuItem
            // 
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDeClientesFrecuentesToolStripMenuItem.Image")));
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem.Name = "mantenimientoDeClientesFrecuentesToolStripMenuItem";
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(285, 24);
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem.Text = "Mantenimiento de clientes frecuentes";
            this.mantenimientoDeClientesFrecuentesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeClientesFrecuentesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.reportesToolStripMenuItem.Text = "Consultar reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // ventaDeAutoschatarraToolStripMenuItem
            // 
            this.ventaDeAutoschatarraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ventaDeAutoschatarraToolStripMenuItem.Image")));
            this.ventaDeAutoschatarraToolStripMenuItem.Name = "ventaDeAutoschatarraToolStripMenuItem";
            this.ventaDeAutoschatarraToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.ventaDeAutoschatarraToolStripMenuItem.Text = "Venta de autos \"chatarra\"";
            this.ventaDeAutoschatarraToolStripMenuItem.Click += new System.EventHandler(this.ventaDeAutoschatarraToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.salirToolStripMenuItem.Text = "Salir del sistema CIV";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pbImagenPrincipal
            // 
            this.pbImagenPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImagenPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbImagenPrincipal.Image")));
            this.pbImagenPrincipal.Location = new System.Drawing.Point(304, 68);
            this.pbImagenPrincipal.Name = "pbImagenPrincipal";
            this.pbImagenPrincipal.Size = new System.Drawing.Size(749, 591);
            this.pbImagenPrincipal.TabIndex = 1;
            this.pbImagenPrincipal.TabStop = false;
            this.pbImagenPrincipal.Click += new System.EventHandler(this.pbImagenPrincipal_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Interfaz_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 630);
            this.Controls.Add(this.pbImagenPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.Font = new System.Drawing.Font("MS Outlook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Interfaz_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".: Sistema CIV - Yonke Magaña:.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Interfaz_Principal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeAutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDePartesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeClientesFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaDeAutoschatarraToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbImagenPrincipal;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}