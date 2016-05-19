using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Interfaz_Mantenimiento_Autos : Form
    {
        public Interfaz_Mantenimiento_Autos()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtbxNombreVendedor, "Ingrese aquí el nombre del vendedor");
            this.ttMensaje.SetToolTip(this.txtbxTelVendedor, "Ingrese aquí el teléfono del vendedor");
            this.ttMensaje.SetToolTip(this.txtbxDirVendedor, "Ingrese aquí la dirección del vendedor");
            this.ttMensaje.SetToolTip(this.txtbxColorAuto, "Ingrese aquí el color del auto");
            this.ttMensaje.SetToolTip(this.txtbxNumeroSerie, "Ingrese aquí los 17 caracteres del número de serie del auto (VIN)");
            this.ttMensaje.SetToolTip(this.cmbMarcaAuto, "Seleccione la marca del auto");
            this.ttMensaje.SetToolTip(this.cmbModeloAuto, "Seleccione el modelo del auto");
            this.ttMensaje.SetToolTip(this.cmbAnioAuto, "Seleccione el año del auto");
            this.ttMensaje.SetToolTip(this.cmbTipoAuto, "Seleccione el tipo de auto");
            this.ttMensaje.SetToolTip(this.cmbCilindros, "Seleccione la cantidad de cilindros del auto");
            this.ttMensaje.SetToolTip(this.txtbxCostoAuto, "Ingrese el costo del auto");
        }

        //COMBOBOX PARA SELECCIONAR MARCA DEL AUTO 
        protected void cmbMarcaAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModeloAuto.Enabled = true;
            int id = int.Parse(cmbMarcaAuto.SelectedValue.ToString());
            cmbModeloAuto.DataSource = NInventario.ObtenerModelos(id);
            cmbModeloAuto.DisplayMember = "modelo";
            cmbModeloAuto.ValueMember = "id_modelo";
        }

        protected void cmbModeloAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        //METODO PARA MOSTRAR MENSAJE DE CONFIRMACION
        private void MensajeOK (string mensaje)
        {
            MessageBox.Show(mensaje,"Sistema CIV",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //METODO PARA MOSTRAR MENSAJE DE ERROR
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //METODO CONSULTA ANTES DE MODIFICAR
        private void ConsultaEspModificar()
        {
            this.dgvConsultaEspModificar.DataSource = NAuto.ConsultarAutoCUAModificar(this.txtbxModifAutoCUA.Text);
            if (this.dgvConsultaEspModificar.RowCount == 0)
            {
                this.btnModificar.Visible = false;
                MessageBox.Show("No se encontró ningún registro con esa clave","Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.btnModificar.Visible = true;
            }
        }

        //METODO PARA LIMPIAR LOS CONTROLES DEL FORMULARIO DE REGISTRO DE AUTOS
        private void Limpiar()
        {
            this.txtbxNombreVendedor.Text = string.Empty;
            this.txtbxDirVendedor.Text = string.Empty;
            this.txtbxTelVendedor.Text = string.Empty;
            this.txtbxColorAuto.Text = string.Empty;
            this.txtbxNumeroSerie.Text = string.Empty;
            this.cmbMarcaAuto.Text = string.Empty;
            this.cmbModeloAuto.Text = string.Empty;
            this.cmbAnioAuto.Text = string.Empty;
            this.cmbTipoAuto.Text = string.Empty;
            this.cmbCilindros.Text = string.Empty;
            this.dgvPartesDisponibles.ClearSelection(); 
            this.dtpFechaCompra.Text = string.Empty;
            this.txtbxCostoAuto.Text = string.Empty;
        }

        private void registroDeAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Interfaz_Mantenimiento_Autos_Load(object sender, EventArgs e)
        {
            cmbMarcaAuto.DataSource = NInventario.ObtenerMarcas();
            cmbMarcaAuto.DisplayMember = "marca";
            cmbMarcaAuto.ValueMember = "id_marca";
            cmbModeloAuto.Enabled = false;
            dgvPartesDisponibles.AutoGenerateColumns = false;
            dgvPartesDisponibles.DataSource = CargarPartes();
            cmbConsAutoMarca.DataSource = NInventario.ObtenerMarcas();
            cmbConsAutoMarca.DisplayMember = "marca";
            cmbConsAutoMarca.ValueMember = "id_marca";
            cmbConsAutoModelo.Enabled = false;
            this.btnModificar.Visible = false;
            //dgvPartesDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private List<DPartes> CargarPartes()
        {
            List<DPartes> ListaPartes = new List<DPartes>();
            using (SqlConnection conexion = new SqlConnection("Data Source=CABRERA\\SQLEXPRESS; Initial Catalog=BDSistemaCIV; Integrated Security=true"))
            {
                conexion.Open();
                string ConsultaPartes = "SELECT * FROM Partes";
                SqlCommand cmd = new SqlCommand(ConsultaPartes, conexion);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    DPartes Partes = new DPartes();
                    Partes.id_parte = Convert.ToInt32(lector[0]);
                    Partes.parte = lector[1].ToString();
                    ListaPartes.Add(Partes);
                }
            }
            return ListaPartes;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtbxNombreVendedor.Text == string.Empty ||
                this.txtbxDirVendedor.Text == string.Empty ||
                this.txtbxTelVendedor.Text == string.Empty ||
                this.cmbMarcaAuto.Text == string.Empty ||
                this.cmbModeloAuto.Text == string.Empty ||
                this.cmbAnioAuto.Text == string.Empty ||
                this.cmbTipoAuto.Text == string.Empty ||
                this.cmbCilindros.Text == string.Empty ||
                this.txtbxColorAuto.Text == string.Empty ||
                this.txtbxNumeroSerie.Text == string.Empty ||
                this.dtpFechaCompra.Text == string.Empty ||
                this.txtbxCostoAuto.Text == string.Empty)
                {
                    MensajeError("Debe de ingresar y/o seleccionar todos los datos del formulario de registro, por favor verifique . . .");
                }
                else
                {
                    //VALIDAR FECHA DE COMPRA DE AUTOS PARA QUE NO SEA POSTERIOR A LA FECHA ACTUAL DEL SISTEMA
                    if (this.dtpFechaCompra.Value > DateTime.Now)
                    {
                        MessageBox.Show("Ha seleccionado una fecha incorrecta, favor de seleccionar una fecha valida e intente de nuevo", "¡Error en la fecha seleccionada!");
                    }
                    else
                    {
                        if (this.txtbxNumeroSerie.TextLength == 17)
                        {
                            foreach (DataGridViewRow row in dgvPartesDisponibles.Rows)
                            {
                                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                                if (chk.EditingCellValueChanged == false &&
                                   !string.IsNullOrEmpty(row.Cells["condicion"].FormattedValue.ToString()) && 
                                    !string.IsNullOrEmpty(row.Cells["Precio"].FormattedValue.ToString()))
                                {
                                    //foreach (DataGridViewRow seleccionado in dgvPartesDisponibles.Rows)
                                    //{
                                        //if (!string.IsNullOrEmpty(chk.Cells["condicion"].FormattedValue.ToString()) && !string.IsNullOrEmpty(chk.Cells["Precio"].FormattedValue.ToString()))
                                        //{
                                            if (MessageBox.Show("¿Desea confirmar su registro de auto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                            {
                                                respuesta = NAuto.Insertar(this.cmbMarcaAuto.Text, this.cmbModeloAuto.Text, Int32.Parse(this.cmbAnioAuto.Text), this.txtbxColorAuto.Text, this.cmbTipoAuto.Text, this.txtbxNumeroSerie.Text,
                                                                            this.cmbCilindros.Text, this.dtpFechaCompra.Text, this.txtbxNombreVendedor.Text, this.txtbxTelVendedor.Text, this.txtbxDirVendedor.Text, this.txtbxCostoAuto.Text);
                                                int cua = NAuto.cuaAuto(); //TRAE LA CUA DEL ULTIMO AUTO REGISTRADO 
                                                foreach (DataGridViewRow row2 in dgvPartesDisponibles.Rows)
                                                {
                                                    if (Convert.ToBoolean(row2.Cells[0].Value))
                                                    {
                                                        string parte = Convert.ToString(row2.Cells[1].Value);
                                                        string condicion = Convert.ToString(row2.Cells[2].Value);
                                                        string precio = Convert.ToString(row2.Cells[3].Value);
                                                        string rpta = NAuto.insertarPartes(parte, condicion, precio, cua);
                                                        if (rpta.Equals("OK"))
                                                        {
                                                            //this.MensajeOK("hasta aqui todo fine");
                                                        }
                                                        else
                                                        {
                                                            this.MensajeError(rpta);
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                            else
                                            {
                                                break;
                                            }
                                        //}
                                        /*else
                                        {
                                            MessageBox.Show("Debe poner condicion y precio a todas las partes seleccionadas, Verifique...", "Aviso");
                                            break;
                                        } */
                                    //}
                                }
                                else
                                {
                                    MessageBox.Show("Debe poner seleccionar por lo menos una parte e indicar se condicion y precio, por favor verifique...", "Aviso");
                                    break;
                                } 
                            }
                            dgvPartesDisponibles.EndEdit();
                        }
                        else
                        {
                            MessageBox.Show("Ha ingresado un número de serie (VIN) con formato incorrecto, el VIN debe de ser compuesto por 17 caracteres, favor de ingresar uno valido e intente de nuevo", "¡Error en el VIN ingresado!");
                        }
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    //MENSAJE DE REGISTRO EXITOSO
                    this.MensajeOK("¡El registro del auto se ha almacenado exitosamente!");
                    //ES UNA BUENA PRACTIA LIMPIAR LOS CAMPOS DEL FORMULARIO DESPUES DE UN REGISTRO
                    this.Limpiar();
                    //DESABILITAR EL TEXTBOX DE LA MARCA Y MODELO DEL AUTO DESPUES DEL REGISTRO Y REGRESARLOS A SU POSICION INICIAL
                    this.cmbMarcaAuto.SelectedIndex = 0;
                    this.cmbModeloAuto.Enabled = false;
                    //LIMPIAR TODOS Y CADA UNO DE LOS DATOS INGRESADOS EN EL DATAGRIDVIEW DE LAS PARTES DISPONIBLES
                    foreach (DataGridViewRow chkbx in dgvPartesDisponibles.Rows)
                    {
                        chkbx.Cells["seleccionar"].Value = false;
                        chkbx.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
                    }
                    foreach (DataGridViewRow dineros in dgvPartesDisponibles.Rows)
                    {
                        dineros.Cells["Precio"].Value = "";
                        dineros.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
                    }
                    foreach (DataGridViewRow cond in dgvPartesDisponibles.Rows)
                    {
                        cond.Cells["condicion"].Value = "";
                        cond.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
                    }
                }
                else
                {
                    //this.MensajeError("El Sistema CIV ha detectado el siguiente error:\n\n" + respuesta + "\n\ny por lo tanto, no se ha podido registrar el auto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //BOTONES PARA SELECCIONAR Y DESELECCIONAR TODAS LAS PARTES DEL LISTBOX
        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow chkbx in dgvPartesDisponibles.Rows)  
            {
                chkbx.Cells["seleccionar"].Value = true;
                chkbx.DefaultCellStyle.BackColor = Color.LightGreen;
            }  
        }

        //METODO PARA LIMPIAR TODAS LAS COLUMNAS AL PRESIONAR BOTON DESELECCIONAR
        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow chkbx in dgvPartesDisponibles.Rows) 
            {
                chkbx.Cells["seleccionar"].Value = false;
                chkbx.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            }

            foreach (DataGridViewRow dineros in dgvPartesDisponibles.Rows)
            {
                dineros.Cells["Precio"].Value = "";
                dineros.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            }

            foreach (DataGridViewRow cond in dgvPartesDisponibles.Rows)
            {
                cond.Cells["condicion"].Value = "";
                cond.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
            }  
        }

        private void btnCancelarRegistroAuto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de borrar los datos ingresados y/o seleccionados, ¿Deseas continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Limpiar();
                
                cmbModeloAuto.Enabled = false;
                int id = int.Parse(cmbMarcaAuto.SelectedValue.ToString());
                cmbModeloAuto.DataSource = NInventario.ObtenerModelos(id);
                cmbModeloAuto.DisplayMember = "modelo";
                cmbModeloAuto.ValueMember = "id_modelo";
            }
        }

        private void lbCondicionPartes_Click(object sender, EventArgs e)
        {

        }

        private void cmbAnioAuto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tpageConsultarAutos_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void mantenimientoDeAutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabctrlMantoAutos.Visible = false;
            lbTitMantoAutos.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de salir del Mantenimiento de autos, ¿Deseas continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdbtnConsultaMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnConsultaMarca.Checked == true)
            {
                cmbConsAutoMarca.Enabled = true;
                cmbConsAutoModelo.Enabled = true;
                cmbConsAutoAI.Enabled = true;
                cmbConsAutoAF.Enabled = true;
                //this.dgvConsultaPartes.DataSource = NAuto.ConsultarPartes("-1");
            }
            else
            {
                cmbConsAutoMarca.Enabled = false;
                cmbConsAutoModelo.Enabled = false;
                cmbConsAutoAI.Enabled = false;
                cmbConsAutoAF.Enabled = false;
                //SI SELECCIONA EL USUARIO OTRO RADIO, LIMPIAR LOS DATOS DEL AUTO SELECCIONADOS
                cmbConsAutoMarca.Text = string.Empty;
                cmbConsAutoModelo.Text = string.Empty;
                cmbConsAutoAI.Text = string.Empty;
                cmbConsAutoAF.Text = string.Empty;
            }
        }

        private void rdbtnConsultaCUA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnConsultaCUA.Checked == true)
            {
                txtbxConsAutoCUA.Enabled = true;
                this.dgvConsultaPartes.DataSource = NAuto.ConsultarPartes("-1");
            }
            else
            {
                txtbxConsAutoCUA.Enabled = false;
                //SI SELECCIONA EL USUARIO OTRO RADIO, LIMPIAR LA CUA INGRESADA
                txtbxConsAutoCUA.Text = string.Empty;
            }
        }

        private void txtbxConsAutoCUA_TextChanged(object sender, EventArgs e)
        {
            if (txtbxConsAutoCUA.TextLength > 0)
            {
                txtbxConsAutoCUA.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxConsAutoCUA.BackColor = Color.FromArgb(255, 224, 192);
            }
        }
        //BOTTON DE LA CONSULTA GENERAL DEL AUTOMOVIL
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rdbtnConsultaMarca.Checked == true)
                {
                    if (this.cmbConsAutoMarca.Text == string.Empty || this.cmbConsAutoModelo.Text == string.Empty || this.cmbConsAutoAI.Text == string.Empty || this.cmbConsAutoAF.Text == string.Empty)
                    {
                        MensajeError("Debe de seleccionar todos los datos, por favor verifique  . . .");
                    }
                    else
                    {
                        //POR SI LA CONSULTA ES POR MARCA MODELO ANIO INICIA Y ANIO FINAL
                        if (rdbtnConsultaMarca.Checked == true)
                        {
                            string marca = cmbConsAutoMarca.Text;
                            string modelo = cmbConsAutoModelo.Text;
                            int anioInicial = int.Parse(cmbConsAutoAI.Text);
                            int anioFinal = int.Parse(cmbConsAutoAF.Text);
                            this.dgvConsultaAuto.DataSource = NAuto.ConsultaAutoGral(marca, modelo, anioInicial, anioFinal);
                            if (this.dgvConsultaAuto.RowCount == 0)
                            {
                                this.dgvConsultaPartes.DataSource = NAuto.ConsultarPartes("0");
                                MessageBox.Show("No se encontró ningún auto con esos parámetros de búsqueda", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                if (rdbtnConsultaCUA.Checked == true)
                {
                    if (this.txtbxConsAutoCUA.Text == string.Empty)
                    {
                        MensajeError("Debe de ingresar la Clave Única del Auto  . . .");
                    }
                    else
                    {
                        string cua = txtbxConsAutoCUA.Text;
                        this.dgvConsultaAuto.DataSource = NAuto.ConsultarAutoCUA(cua);
                        if (this.dgvConsultaAuto.RowCount == 0)
                        {
                            this.dgvConsultaPartes.DataSource = NAuto.ConsultarPartes("0");
                            MessageBox.Show("No se encontró ningún auto con la clave ingresada", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //METODO PARA CONVERTIR EL TEXTO INTRUDUCIDO A LOS TEXTBOXES A MAYUSCULAS
        public CharacterCasing CharacterCasing { get; set; }

        //METODO PARA ESTABLECER UN MAXIMO DE LONGITUD DE CADENA, EN ESTE CASO AL txtbxNumeroSerie QUE DEBERA SER DE 17 CARACTERES MAXIMO
        public int MaxLength { get; set; }

        private void txtbxNombreVendedor_TextChanged(object sender, EventArgs e)
        {
            txtbxNombreVendedor.CharacterCasing = CharacterCasing.Upper;
            if (txtbxNombreVendedor.TextLength > 0)
            {
                txtbxNombreVendedor.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxNombreVendedor.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxTelVendedor_TextChanged(object sender, EventArgs e)
        {
            txtbxTelVendedor.CharacterCasing = CharacterCasing.Upper;
            if (txtbxTelVendedor.TextLength > 0)
            {
                txtbxTelVendedor.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxTelVendedor.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxDirVendedor_TextChanged(object sender, EventArgs e)
        {
            txtbxDirVendedor.CharacterCasing = CharacterCasing.Upper;
            if (txtbxDirVendedor.TextLength > 0)
            {
                txtbxDirVendedor.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxDirVendedor.BackColor = Color.FromArgb(255, 224, 192);
            } 
        }

        private void txtbxColorAuto_TextChanged(object sender, EventArgs e)
        {
            txtbxColorAuto.CharacterCasing = CharacterCasing.Upper;
            if (txtbxColorAuto.TextLength > 0)
            {
                txtbxColorAuto.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxColorAuto.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxNumeroSerie_TextChanged(object sender, EventArgs e)
        {
            txtbxNumeroSerie.CharacterCasing = CharacterCasing.Upper;
            txtbxNumeroSerie.MaxLength = 17;
            if (txtbxNumeroSerie.TextLength > 0)
            {
                txtbxNumeroSerie.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxNumeroSerie.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        //MUESTRA LAS MARCAS Y MODELOS EN LA CONSULTA DEL AUTOMOVIL
        private void cmbConsAutoMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbConsAutoModelo.Enabled = true;
            int id = int.Parse(cmbConsAutoMarca.SelectedValue.ToString());
            cmbConsAutoModelo.DataSource = NInventario.ObtenerModelos(id);
            cmbConsAutoModelo.DisplayMember = "modelo";
            cmbConsAutoModelo.ValueMember = "id_modelo";
        }

        //VALIDAR SOLO DIGITOS
        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //VALIDAR SOLO LETRAS
        private void txtbxModifAutoCUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnModifAutoCUA_Click(object sender, EventArgs e)
        {
            if (this.txtbxModifAutoCUA.Text == string.Empty)
            {
                this.MensajeError("Favor de ingresar la Clave Única del Auto (CUA)");
            }
            else
            {
                this.ConsultaEspModificar();
                this.Limpiar();
                this.dgvConsultaEspModificar.Columns[0].ReadOnly = true;
                this.dgvConsultaEspModificar.Columns[6].ReadOnly = true;
                
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                int cuc = Int32.Parse(dgvConsultaEspModificar.Rows[0].Cells[0].Value.ToString());
                string marca = dgvConsultaEspModificar.Rows[0].Cells[1].Value.ToString();
                string modelo = dgvConsultaEspModificar.Rows[0].Cells[2].Value.ToString();
                string anio = dgvConsultaEspModificar.Rows[0].Cells[3].Value.ToString();
                string color = dgvConsultaEspModificar.Rows[0].Cells[4].Value.ToString();
                string tipoAuto = dgvConsultaEspModificar.Rows[0].Cells[5].Value.ToString();
                string numeroSerie = dgvConsultaEspModificar.Rows[0].Cells[6].Value.ToString();
                if (marca == string.Empty || modelo == string.Empty || anio == string.Empty || color == string.Empty || tipoAuto == string.Empty || numeroSerie == string.Empty)
                {
                    this.MensajeError("Por favor introduzca todos los datos del Auto");
                }
                else
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("¿Esta seguro de modificar estos datos?", "Sistema CIV", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        respuesta = NAuto.Modificar(cuc, marca, modelo, anio, color, tipoAuto,numeroSerie);
                        btnModificar.Visible = false;
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    this.MensajeOK("¡El registro del Auto se ha modificado exitosamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvConsultaAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string cua = dgvConsultaAuto.Rows[e.RowIndex].Cells["CUAConsulta"].Value.ToString();
                this.dgvConsultaPartes.DataSource = NAuto.ConsultarPartes(cua);
            }
        }

        private void txtbxModifAutoCUA_TextChanged(object sender, EventArgs e)
        {
            if (txtbxModifAutoCUA.TextLength > 0)
            {
                txtbxModifAutoCUA.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxModifAutoCUA.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void dgvPartesDisponibles_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
        }

        private void dgvPartesDisponibles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvPartesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPartesDisponibles_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
         
        }

        //AQUI HACEMOS QUE AL SELECCIONAR UN CHECKBOX DE UNA PARTE SE ACTIVEN LOS CAMPOS DE SU FILA (CONDICION Y PRECIO)
        private void dgvPartesDisponibles_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPartesDisponibles.IsCurrentCellDirty)
            {
                dgvPartesDisponibles.CommitEdit(DataGridViewDataErrorContexts.Commit);
                foreach (DataGridViewRow row in dgvPartesDisponibles.Rows)
                {  
                    DataGridViewCheckBoxCell cell = row.Cells["seleccionar"] as DataGridViewCheckBoxCell; 
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        row.Cells["condicion"].ReadOnly = false;
                        row.Cells["Precio"].ReadOnly = false;
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        row.Cells["Precio"].Value = "";
                        row.Cells["condicion"].Value = "";
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 224, 192);
                    }
                }
            }
        }

        private void dgvPartesDisponibles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtbxCostoAuto_TextChanged(object sender, EventArgs e)
        {
            if (txtbxCostoAuto.TextLength > 0)
            {
                txtbxCostoAuto.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxCostoAuto.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void dtpFechaCompra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
