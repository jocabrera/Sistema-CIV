using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Interfaz_Principal : Form
    {
        public Interfaz_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de salir de la aplicación, ¿Deseas continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mantenimientoDeAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Autos ma = new Interfaz_Mantenimiento_Autos();
            ma.Show();
        }

        private void txtbxFecha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbxHora_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void Interfaz_Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void calendarioInicio_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void mantenimientoDeClientesFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz_Mantenimiento_Clientes mcf = new Interfaz_Mantenimiento_Clientes();
            mcf.Show();
        }

        private void ventaDePartesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz_Venta_Partes vp = new Interfaz_Venta_Partes();
            vp.Show();
        }

        private void ventaDeAutoschatarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz_Venta_Autos va = new Interfaz_Venta_Autos();
            va.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfaz_Reportes rep = new interfaz_Reportes();
            rep.Show();
        }

        private void pbImagenPrincipal_Click(object sender, EventArgs e)
        {

        }
    }
}
