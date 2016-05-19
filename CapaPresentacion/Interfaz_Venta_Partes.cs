using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class Interfaz_Venta_Partes : Form
    {
        public Interfaz_Venta_Partes()
        {
            InitializeComponent();
             
        }
       

        private void btnSalirVP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de salir de la venta de partes, ¿Deseas continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        protected void cmbMarcaAutoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModeloAutoVenta.Enabled = true;
            int id = int.Parse(cmbMarcaAutoVenta.SelectedValue.ToString());
            cmbModeloAutoVenta.DataSource = NInventario.ObtenerModelos(id);
            cmbModeloAutoVenta.DisplayMember = "modelo";
            cmbModeloAutoVenta.ValueMember = "id_modelo";
        }

        private void cmbModeloAutoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Interfaz_Venta_Partes_Load(object sender, EventArgs e)
        {
            cmbMarcaAutoVenta.DataSource = NInventario.ObtenerMarcas();
            cmbMarcaAutoVenta.DisplayMember = "marca";
            cmbMarcaAutoVenta.ValueMember = "id_marca";
            cmbModeloAutoVenta.Enabled = false;
        }

        //METODO PARA MOSTRAR MENSAJE DE ERROR
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //BOTON DE CONSULTAR EN LA PARTE DE VENTAS
        private void btnAceptarVta_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbMarcaAutoVenta.Text == string.Empty || this.cmbModeloAutoVenta.Text == string.Empty || this.cmbAIVenta.Text == string.Empty || 
                    this.cmbAFVenta.Text == string.Empty || this.cmbTipoAutoVenta.Text == string.Empty || this.cmbCilindrosVenta.Text == string.Empty)
                {
                    MensajeError("Debe de seleccionar todos los datos, por favor verifique  . . .");
                }
                else
                {
                    string marca = cmbMarcaAutoVenta.Text;
                    string modelo = cmbModeloAutoVenta.Text;
                    int anioInicial = int.Parse(cmbAIVenta.Text);
                    int anioFinal = int.Parse(cmbAFVenta.Text);
                    string tipoAuto = cmbTipoAutoVenta.Text;
                    string cantidadCilindros = cmbCilindrosVenta.Text;
                    this.dgvConsultaPartesVenta.DataSource = NAuto.ConsultarPartes("-1");
                    this.dgvConsultaAutoVenta.DataSource = NVenta.ConsultaAutoVenta(marca, modelo, anioInicial, anioFinal, tipoAuto, cantidadCilindros);
                    if (this.dgvConsultaAutoVenta.RowCount == 0)
                    {
                        this.dgvConsultaPartesVenta.DataSource = NAuto.ConsultarPartes("0");
                        MessageBox.Show("No se encontró ningún registro con esas características", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //DGV DE LA CONSULTA DE LOS AUTOS EN LA VENTA       
        private void dgvVentaDatosAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                string cua = dgvConsultaAutoVenta.Rows[e.RowIndex].Cells["CUAVenta"].Value.ToString();
                this.dgvConsultaPartesVenta.DataSource = NAuto.ConsultarPartes(cua);
               // btnCotizar.Enabled = true;
                
            }
        }
        //ES EL DGV DE LAS PARTES EN LA VENTA
        private void dgvConsultaPartesVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvConsultaPartesVenta.Rows[e.RowIndex].Cells["CUAPartes"].Value.ToString());
            btnCotizar.Enabled = true;
        }

        //EVENTO PARA BOTON COTIZAR DE LA VENTA
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            //VALIDAR AQUI QUE SE SELECCIONE POR LO MENOS UNA PARTE ANTES DE APARECER LA INTERFAZ DE COTIZACION
                NVenta.EliminarCotizacion();
                Boolean ban = false;
                foreach (DataGridViewRow row in dgvConsultaPartesVenta.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        string id = Convert.ToString(row.Cells[1].Value);
                   
                        string rpta = NVenta.insertarCotizacion(int.Parse(id));

                        if (rpta.Equals("OK"))
                        {
                            ban = true;
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }
                }
               // this.dgvConsultaPartesVenta.DataSource = NAuto.ConsultarPartes("-1");
                if (ban == true)
                {
                    Interfaz_Comprobante comp = new Interfaz_Comprobante(-1);
                    comp.Show(this);
                    btnCotizar.Enabled = false;
                }
                else
                {
                    btnCotizar.Enabled = false;
                    MessageBox.Show("No sé a seleccionado ninguna parte aun", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (txtbxFolio.Text == string.Empty)
            {
                MessageBox.Show("No dejar el campo vacio", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int folio = int.Parse(txtbxFolio.Text);
                Interfaz_Comprobante comp = new Interfaz_Comprobante(folio);
                comp.Show(this);
                this.dgvConsultaPartesVenta.DataSource = NAuto.ConsultarPartes("-1");
                txtbxFolio.Text = " ";
            }
                   
            
        }

        private void txtbxfolio(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbxFolio_TextChanged(object sender, EventArgs e)
        {
            if (txtbxFolio.TextLength > 0)
            {
                txtbxFolio.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxFolio.BackColor = Color.FromArgb(255, 224, 192);
            }
        }
    }
}
