using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Interfaz_Venta_Autos : Form
    {

        public Interfaz_Venta_Autos()
        {
            InitializeComponent();
        }

        //MENSAJE DE CONFIRMACION
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "SistemaCIV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //MENSAJE DE ERROR
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SistemaCIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //METODO QUE MANDA LLAMAR LA LISTA DE AUTOS DE LA BASE DE DATOS
        private void mostrarListaAutos()
        {
            this.dgvAutos.DataSource = NVentaAutos.mostrarAutos();
            lbRegistros.Text = "Total de registros: " + Convert.ToString(dgvAutos.RowCount);
        }

        //METODO QUE CARGA LA VENTANA Y MUESTRA LA LISTA DE LOS AUTOS
        private void FrmVentaAuto_Load(object sender, EventArgs e)
        {
            this.mostrarListaAutos();
        }

        //METODO QUE HABILITA SELECCIONAR LOS CHECKBOXS DE LA COLUMNA SELECCIONAR
        private void dgvAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvAutos.Columns["Seleccionar"].Index)
                {
                    DataGridViewCheckBoxCell ChkSeleccionar = (DataGridViewCheckBoxCell)dgvAutos.Rows[e.RowIndex].Cells["Seleccionar"];
                    ChkSeleccionar.Value = !Convert.ToBoolean(ChkSeleccionar.Value);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        //METODO QUE MANDA MENSAJE DE ADVERTENCIA QUE NO DEJA INGRESAR CARACTERES QUE NO SEAN NUMEROS
        private void txtbxTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) & (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        //ESTE BOTON TIENE LA ACCION DE OBTENER TODOS LOS AUTOS SELECCIONADOS Y EL TOTAL DE LA VENTA DE LOS MISMOS
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean blnEliminar = false;
            Boolean blnVacio = true;
            int contAutosTotales = 0;

            try
            {
                if (txtbxTotal.Text == String.Empty)
                {
                    this.MensajeError("El total no se ha ingresado.");
                }
                else
                {
                    foreach (DataGridViewRow row in dgvAutos.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            contAutosTotales++;
                            blnVacio = false;
                        }
                    }
                    if (blnVacio == false && contAutosTotales == 3)
                    {
                        DialogResult Opcion;
                        Opcion = MessageBox.Show("¿Realmente desea vender los autos por la cantidad de $" + txtbxTotal.Text + " ?", "Sistema CIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (Opcion == DialogResult.OK)
                        {
                            string codigo;
                            string rpta = "";

                            foreach (DataGridViewRow row in dgvAutos.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value))
                                {
                                    codigo = Convert.ToString(row.Cells[2].Value);
                                    NVenta.EliminarParteFull(Convert.ToInt32(codigo));
                                    rpta = NVentaAutos.eliminarAutos(Convert.ToInt32(codigo));

                                    if (rpta.Equals("OK"))
                                    {
                                        blnEliminar = true;
                                    }
                                    else
                                    {
                                        this.MensajeError(rpta);
                                    }
                                }
                            }
                            if (blnEliminar == true)
                            {
                                this.MensajeOK("Se eliminaron los autos.");
                                txtbxTotal.Text = String.Empty;
                            }
                            this.mostrarListaAutos();
                        }
                    }
                    else if (contAutosTotales < 3)
                    {
                        this.MensajeError("La cantidad de autos seleccionada es menor a la requerida.");
                    }
                    else if (contAutosTotales > 3)
                    {
                        this.MensajeError("Ha seleccionado mas autos de los permitidos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //ESTE BOTON SIRVE PARA LIMPIAR LOS CHECKBOXS Y LIMPIAR EL CUADRO DE TEXTO DEL TOTAL
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAutos.Rows)
            {
                DataGridViewCheckBoxCell chkSeleccionar = (DataGridViewCheckBoxCell)row.Cells[0];
                chkSeleccionar.Value = false;

                txtbxTotal.Text = null;
            }
        }

        //ESTE BOTON CIERRA LA VENTANA DE VENTA DE AUTOS "CHATARRA"
        private void btnSalirVA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de salir de la venta de autos, ¿Deseas continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lbRegistros_Click(object sender, EventArgs e)
        {

        }

        private void txtbxTotal_TextChanged(object sender, EventArgs e)
        {
            /*if (txtbxTotal.TextLength > 0)
            {
                txtbxTotal.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxTotal.BackColor = Color.FromArgb(255, 224, 192);
            }*/
        }

    }
}
