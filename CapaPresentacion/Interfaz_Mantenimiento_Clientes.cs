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

namespace CapaPresentacion
{
    public partial class Interfaz_Mantenimiento_Clientes : Form
    {
        public Interfaz_Mantenimiento_Clientes()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtbxNombreCliente, "Ingrese aquí el nombre o razón social del cliente");
            this.ttMensaje.SetToolTip(this.txtbxDireccionCliente, "Ingrese aquí la dirección del cliente frecuente");
            this.ttMensaje.SetToolTip(this.txtbxTelefonoCliente, "Ingrese aquí el teléfono del cliente frecuente");
            this.ttMensaje.SetToolTip(this.cmbDescuentoCliente, "Seleccione el descuento a asignar al cliente frecuente");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_Mantenimiento_Clientes_Load(object sender, EventArgs e)
        {
            this.btnModificar.Visible = false;
            this.btnEliminar.Visible = false;
        }

        //METODO PARA MOSTRAR MENSAJE DE CONFIRMACION
        private void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //METODO PARA MOSTRAR MENSAJE DE ERROR
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //METODO PARA LIMPIAR TODOS LOS CAMPOS DE TEXTO
        private void Limpiar()
        {
            this.txtbxNombreCliente.Text = string.Empty;
            this.txtbxDireccionCliente.Text = string.Empty;
            this.txtbxTelefonoCliente.Text = string.Empty;
            this.txtbxClaveBuscar.Text = string.Empty;
            this.txtbxClaveClienteEliminar.Text = string.Empty;
            this.txtbxClaveClienteModificar.Text = string.Empty;
            this.cmbDescuentoCliente.Text = string.Empty;
        }

        //METODO PARA LA CONSULTA GENERAL
        private void ConsultaGral()
        {
            this.dgvConsultaGral.DataSource = NCliente.ConsultaGral();
            lbTotal.Text = "Total de registros: " + Convert.ToString(dgvConsultaGral.Rows.Count);
            
        }

        //METODO PARA CONSULTA ESPECIFICA
        private void ConsultaEsp()
        {
            this.dgvConsultaEsp.DataSource = NCliente.ConsultaEsp(Int32.Parse(this.txtbxClaveBuscar.Text));
            if (this.dgvConsultaEsp.RowCount == 0)
            {
                MessageBox.Show("No se encontró ningún registro con una clave", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO CONSULTA ANTES DE ELIMINAR
        private void ConsultaEspEliminar()
        {
            this.dgvConsultaEspEliminar.DataSource = NCliente.ConsultaEsp(Int32.Parse(this.txtbxClaveClienteEliminar.Text));
            if (this.dgvConsultaEspEliminar.RowCount == 0)
            {
                this.btnEliminar.Visible = false;
                this.dgvConsultaEspEliminar.DataSource = NCliente.ConsultaEsp(0);
                MessageBox.Show("No se encontró ningún registro con una clave", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
            else
            {
                btnEliminar.Visible = true;
            }
        }

        private void txtbxClaveBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tpageModificarCliente_Click(object sender, EventArgs e)
        {

        }
       

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtbxNombreCliente.Text == string.Empty ||
                    this.txtbxDireccionCliente.Text == string.Empty ||
                    this.txtbxTelefonoCliente.Text == string.Empty ||
                    this.cmbDescuentoCliente.Text == string.Empty)
                {
                    MensajeError("Debe ingresar y/o seleccionar todos los datos del formulario de registro, por favor verifique . . .");
                }
                else
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("La información agregada se registrará como nuevo cliente", "Sistema CIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        string fecha_ultima_compra = DateTime.Now.ToString("d");
                        respuesta = NCliente.Insertar(this.txtbxNombreCliente.Text, this.txtbxDireccionCliente.Text, this.txtbxTelefonoCliente.Text, this.cmbDescuentoCliente.Text, fecha_ultima_compra);
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOK("¡El registro del cliente se ha almacenado exitosamente! ");
                    Limpiar();
                }
                else
                {
                    //this.MensajeError("El sistema civ ha detectado el siguiente error:\n\n" + respuesta + "\n\ny por lo tanto, no se ha podido registrar el cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtbxClaveBuscar.Text == string.Empty)
            {
                this.MensajeError("Por favor no dejar el campo vacío");
            }
            else
            {
                this.ConsultaEsp();
                this.Limpiar();
            }
        }

        private void btnConsultaGral_Click(object sender, EventArgs e)
        {
            this.ConsultaGral();
        }

        private void btnSalirMC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de salir del Mantenimiento de clientes frecuente, ¿Deseas continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelarRegistroCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de borrar los datos ingresados y/o seleccionados, ¿Deseas continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
            }
        }

        //METODO DEL BOTON BUSCAR CUC PARA MODIFICAR 
        private void btnBuscarModificar_Click(object sender, EventArgs e)
        {
            if (this.txtbxClaveClienteModificar.Text == string.Empty)
            {
                this.MensajeError("Favor de ingresar la Clave Única de Cliente (CUC)");
            }
            else
            {
                this.ConsultaEspModificar();
                this.Limpiar();
                this.dgvConsultaEspModificar.Columns[0].ReadOnly = true;
                this.dgvConsultaEspModificar.Columns[5].ReadOnly = true;
                
            }
        }
        //METODO CONSULTA ANTES DE MODIFICAR
        private void ConsultaEspModificar()
        {
            this.dgvConsultaEspModificar.DataSource = NCliente.ConsultaEsp(Int32.Parse(this.txtbxClaveClienteModificar.Text));
            if (this.dgvConsultaEspModificar.RowCount == 0)
            {
                this.btnModificar.Visible = false;
                this.dgvConsultaEspModificar.DataSource = NCliente.ConsultaEsp(0);
                MessageBox.Show("No se encontró ningún registro con una clave", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                btnModificar.Visible = true;
            }
            
        }

        //METODO DEL BOTON MODIFICAR PARA REALIZAR LOS CAMBIOS 
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                int cuc = Int32.Parse(dgvConsultaEspModificar.Rows[0].Cells[0].Value.ToString());
                string nombre = dgvConsultaEspModificar.Rows[0].Cells[1].Value.ToString();
                string direccion = dgvConsultaEspModificar.Rows[0].Cells[2].Value.ToString();
                string telefono = dgvConsultaEspModificar.Rows[0].Cells[3].Value.ToString();
                string descuento = dgvConsultaEspModificar.Rows[0].Cells[4].Value.ToString();
                string fecha_ultima_compra = dgvConsultaEspModificar.Rows[0].Cells[5].Value.ToString();
                if (nombre == string.Empty || direccion == string.Empty || telefono == string.Empty || descuento == string.Empty || fecha_ultima_compra == string.Empty)
                {
                    this.MensajeError("Por favor introduzca todos los datos del cliente");
                }
                else
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Esta seguro de modificar estos datos?", "Sistema CIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        respuesta = NCliente.Modificar(cuc, nombre, direccion, telefono, descuento, fecha_ultima_compra);
                        btnModificar.Visible = false;
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOK("¡El registro del cliente se ha modificado exitosamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar este registro?", "Sistema CIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    respuesta = NCliente.Eliminar(Int32.Parse(dgvConsultaEspEliminar.Rows[0].Cells[0].Value.ToString()));
                    btnEliminar.Visible = false;
                }
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOK("¡El registro del cliente se ha eliminado exitosamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            if (this.txtbxClaveClienteEliminar.Text == string.Empty)
            {
                MensajeError("Por favor agregue una clave para eliminar");
            }
            else
            {
                this.ConsultaEspEliminar();
               
            }
        }

        private void dgvConsultaGral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbxNombreCliente_TextChanged(object sender, EventArgs e)
        {
            txtbxNombreCliente.CharacterCasing = CharacterCasing.Upper;
            if (txtbxNombreCliente.TextLength > 0)
            {
                txtbxNombreCliente.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxNombreCliente.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxDireccionCliente_TextChanged(object sender, EventArgs e)
        {
            txtbxDireccionCliente.CharacterCasing = CharacterCasing.Upper;
            if (txtbxDireccionCliente.TextLength > 0)
            {
                txtbxDireccionCliente.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxDireccionCliente.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            txtbxTelefonoCliente.CharacterCasing = CharacterCasing.Upper;
            if (txtbxTelefonoCliente.TextLength > 0)
            {
                txtbxTelefonoCliente.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxTelefonoCliente.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxClaveBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbxClaveClienteEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dgvConsultaEspModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtbxTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtbxClaveBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtbxClaveBuscar.TextLength > 0)
            {
                txtbxClaveBuscar.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxClaveBuscar.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxClaveClienteModificar_TextChanged(object sender, EventArgs e)
        {
            if (txtbxClaveClienteModificar.TextLength > 0)
            {
                txtbxClaveClienteModificar.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxClaveClienteModificar.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxClaveClienteEliminar_TextChanged(object sender, EventArgs e)
        {
            if (txtbxClaveClienteEliminar.TextLength > 0)
            {
                txtbxClaveClienteEliminar.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxClaveClienteEliminar.BackColor = Color.FromArgb(255, 224, 192);
            }
        }
    }
}
