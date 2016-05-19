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
    public partial class Interfaz_Comprobante : Form
    {
        int folio;
        public Interfaz_Comprobante(int fol)
        {
            this.folio = 0;
            InitializeComponent();
            this.folio = fol;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9","SistemaCIV Dice:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo solo permite ingresar digitos del 0 - 9","SistemaCIV Dice:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        //METODO LOAD DE LA INTERFAZ
        private void Interfaz_Comprobante_Load(object sender, EventArgs e)
        {
            //OBTIENE LA FECHA Y HORA ACTUAL DEL SISTEMA
            lbFecha.Text = DateTime.Now.ToString ("yyyy-MM-dd");
            ckbxGuardarCotizacion.Enabled = false;
            if (folio == -1)
            {
                this.dgvConsultaCotizacion.DataSource = NVenta.ConsultaCotizacion();
                this.dgvConsultaCotizacion.Columns["Id_Cotizacion"].Visible = false;
                this.dgvConsultaCotizacion.Columns["Id_item"].Visible = false;
                ckbxGuardarCotizacion.Enabled = true;
            }
            else
            {
                try
                {
                    this.dgvConsultaCotizacion.DataSource = NVenta.ConsultaEspPresupuesto(folio);
                    if (dgvConsultaCotizacion.Rows[0].Cells[4].Value.ToString() == String.Empty)
                    {
                        this.dgvConsultaCotizacion.Columns["Id_Presupuesto"].Visible = false;
                        this.dgvConsultaCotizacion.Columns["Id_item"].Visible = false;
                        this.dgvConsultaCotizacion.Columns["folio"].Visible = false;
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Folio no registrado", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
            

            double total=0; //VARIABLE PARA CONTABILIZAR EL TOTAL DE LAS PARTES SELECCIONADAS A VENDER      
            total = dgvConsultaCotizacion.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["PrecioCotizacion"].Value));
            lbTotalCotizacion.Text = total.ToString();
            lbDescuentoCotizacion.Text = "0";
            lbTotalCotizacion.Text = total.ToString();
            lbAhorroCotizacion.Text = "0";
            lbTotalPagarCotizacion.Text = lbTotalCotizacion.Text;
            txtbxCUCCotizacion.ReadOnly = true; 
        }

        //METODO QUE SE EJECUTA CUANDO DAS CLIC EN EL BOTON DE VALIDAD SI ES CLIENTE 
        private void btnValidarCotizacion_Click(object sender, EventArgs e)
        {
            if (this.txtbxCUCCotizacion.Text == string.Empty)
            {
                MessageBox.Show("Debe de ingresar una CUC, por favor verifique  . . .","SistemaCIV Dice:");
            }
            else
            {
                try { 
                    int cuc = int.Parse(txtbxCUCCotizacion.Text);
                    double Tdesc = 0, desc = 0, totalPagar;
                    DataTable dt = new DataTable();
                    dt = NCliente.ConsultaEsp(cuc);

                    DataRow row = dt.Rows[0];
                    lbDescuentoCotizacion.Text = Convert.ToString(row["Descuento"]);
                    txtbxClienteCotizacion.Text = Convert.ToString(row["Nombre"]);
                    string[] descuento = lbDescuentoCotizacion.Text.Split(' ');

                    MessageBox.Show("El cliente tiene un " + descuento[0] + " % de descuento", "SistemaCIV Dice:");
                    for (int x = 1; x <= 30; x++)
                    {
                        if (int.Parse(descuento[0]) == x)
                        {
                            desc = x;
                        }
                    }
                    descuento[0] = "." + descuento[0];
                    Tdesc = (int.Parse(lbTotalCotizacion.Text) * (double.Parse(descuento[0])));
                    totalPagar = int.Parse(lbTotalCotizacion.Text) - Tdesc;
                    lbTotalPagarCotizacion.Text = totalPagar.ToString();
                    lbAhorroCotizacion.Text = Tdesc.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La clave del cliente no se encuentra en el sistema", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtbxClienteCotizacion.Text = " ";
                    lbDescuentoCotizacion.Text = "0";
                    lbAhorroCotizacion.Text = "0 ";
                    this.lbTotalPagarCotizacion.Text = lbTotalCotizacion.Text;
                    txtbxCUCCotizacion.Text = "";
                }
            }
        }

        //EVENTO PARA CUANDO SE COBRA EL MONTO TOTAL AL CLIENTE
        private void btnCobrarCotizacion_Click(object sender, EventArgs e)
        {
            double cambio = 0;
            double recibido=0 ;
            if (txtbxRecibidoCotizacion.Text == string.Empty)
            {
                MessageBox.Show("Ingresar monto recibido del cliente!", "SistemaCIV Dice:");
            }
            else
            {
               recibido = double.Parse(txtbxRecibidoCotizacion.Text);
            }
            
            if (recibido < double.Parse(lbTotalPagarCotizacion.Text))
            {
                MessageBox.Show("La cantidad recibida es insuficiente!","SistemaCIV Dice:");
            }
            else
            {
                try
                {
                    string respuesta="",nombreCliente;
                    int cuc, desc=0;
                    ;
                    string[] descuento = lbDescuentoCotizacion.Text.Split(' ');

                    //PARA SACAR CUANTO DESCUENTO TIENE EL CLIENTE DEL 1 AL 30%
                    for (int x = 1; x <= 30; x++)
                    {
                        if (int.Parse(descuento[0]) == x)
                        {
                            desc = x;
                        }
                    }
                    //CHECAR QUE EL CAMPO ESTE LLENO
                    if (txtbxCUCCotizacion.Text == string.Empty)
                    {
                        cuc = 0;
                        nombreCliente = " ";
                    }
                    else
                    {
                         cuc = int.Parse(txtbxCUCCotizacion.Text);
                         nombreCliente = txtbxClienteCotizacion.Text;
                    }
                    cambio = recibido - double.Parse(lbTotalPagarCotizacion.Text);
                    txtbxCambioCotizacion.Text = cambio.ToString();

                    if (folio == -1)
                    {
                        //FOREACH PARA INGRESAR EN LA TABLA VENTAS LA VENTA QUE SE REALIZARA
                        foreach (DataGridViewRow row in dgvConsultaCotizacion.Rows)
                        {

                            int id_cotizacion = Convert.ToInt32(row.Cells[0].Value);
                            int id_item = Convert.ToInt32(row.Cells[1].Value);
                            string parte = Convert.ToString(row.Cells[2].Value);
                            string marca = Convert.ToString(row.Cells[3].Value);
                            string modelo = Convert.ToString(row.Cells[4].Value);
                            int anio = Convert.ToInt32(row.Cells[5].Value);
                            string precio = Convert.ToString(row.Cells[6].Value);
                            NVenta.EliminarPartePresupuesto(id_item);
                            string spta = NVenta.EliminarParte(id_item);
                           
                            if (spta.Equals("OK"))
                            {
                                respuesta = NVenta.insertarVenta(id_cotizacion, cuc, nombreCliente, lbFecha.Text, parte, marca, modelo, anio, precio,
                                float.Parse(txtbxRecibidoCotizacion.Text), float.Parse(txtbxCambioCotizacion.Text), float.Parse(lbTotalCotizacion.Text),
                                (float)desc, float.Parse(lbTotalPagarCotizacion.Text), float.Parse(lbAhorroCotizacion.Text));
                            }
                           

                            if (respuesta.Equals("OK") && spta.Equals("OK"))
                            {
                                if (txtbxCUCCotizacion.Text != string.Empty)
                                {
                                    NVenta.ModificarFechaUltimaCompra(int.Parse(txtbxCUCCotizacion.Text), lbFecha.Text);
                                }
                                btnImprimirCotizacion.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error en la venta", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            btnCobrarCotizacion.Enabled = false;
                            //btnImprimirCotizacion.Visible = true;
                            ckbxGuardarCotizacion.Enabled = false;

                        }
                    }
                    else
                    {
                        //FOREACH PARA INGRESAR EN LA TABLA VENTAS LA VENTA QUE SE REALIZARA
                        foreach (DataGridViewRow row in dgvConsultaCotizacion.Rows)
                        {

                            int id_cotizacion = 0;
                            int id_item = Convert.ToInt32(row.Cells[2].Value);
                            string parte = Convert.ToString(row.Cells[3].Value);
                            string marca = Convert.ToString(row.Cells[4].Value);
                            string modelo = Convert.ToString(row.Cells[5].Value);
                            int anio = Convert.ToInt32(row.Cells[6].Value);
                            string precio = Convert.ToString(row.Cells[7].Value);

                            respuesta = NVenta.insertarVenta(id_cotizacion, cuc, nombreCliente, lbFecha.Text, parte, marca, modelo, anio, precio,
                                float.Parse(txtbxRecibidoCotizacion.Text), float.Parse(txtbxCambioCotizacion.Text), float.Parse(lbTotalCotizacion.Text),
                                (float)desc, float.Parse(lbTotalPagarCotizacion.Text), float.Parse(lbAhorroCotizacion.Text));
                            NVenta.EliminarPresupuesto(folio);

                            string spta = NVenta.EliminarParte(id_item);
                           
                            if (respuesta.Equals("OK") && spta.Equals("OK"))
                            {
                                if (txtbxCUCCotizacion.Text != string.Empty)
                                {
                                    NVenta.ModificarFechaUltimaCompra(int.Parse(txtbxCUCCotizacion.Text), lbFecha.Text);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error en la venta", "Sistema CIV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            btnCobrarCotizacion.Enabled = false;
                            btnImprimirCotizacion.Visible = true;
                            ckbxGuardarCotizacion.Enabled = false;

                        }
                    }
                    if(respuesta.Equals("OK")){
                          MessageBox.Show("Gracias por su compra", "SistemaCIV Dice:");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                
            }
        }

        //METODO PARA REGRESAR AL VENTA( CERRAR LA COTIZACIÓN)
        private void brnRegresarCotizacion_Click(object sender, EventArgs e)
        {
            string rpta = "NO";
            if (Convert.ToBoolean(ckbxGuardarCotizacion.Checked))
            {

                int folioo = NVenta.folioPresupuesto();               
                if (folioo == null)
                {
                    folioo = 1;
                }
                else
                {
                    folioo = folioo + 1;
                }
                foreach (DataGridViewRow row in dgvConsultaCotizacion.Rows)
                {                   
                      string id_item = Convert.ToString(row.Cells[1].Value);

                      string parte = Convert.ToString(row.Cells[2].Value); 
                      string marca = Convert.ToString(row.Cells[3].Value); 
                      string modelo = Convert.ToString(row.Cells[4].Value);
                      string anio = Convert.ToString(row.Cells[5].Value); 
                      string precio = Convert.ToString(row.Cells[6].Value);

                       rpta = NVenta.insertarPresupuesto(folioo, int.Parse(id_item),parte, marca, modelo, int.Parse(anio),precio);

                      if (rpta.Equals("OK"))
                      {
                          //MessageBox.Show("Presupuesto guardado, Numero de folio para el cliente es: "+folioo);
                      }
                      else
                      {
                          MessageBox.Show(rpta);
                      }
                    
                }
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Presupuesto guardado, Numero de folio para el cliente es:  " + folioo, "Sistema CIV");
                }
                
            }
            this.Close();
        }

        //METODO QUE SE HARA CUANDO LE DE CLICk EN QUE ES CLIENTE FRECUENTE 
        private void ckbxClienteCotizacion_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(ckbxClienteCotizacion.Checked))
            {
                lbCUC.Visible = true;
                txtbxCUCCotizacion.Visible = true;
                txtbxCUCCotizacion.ReadOnly = false;
                btnValidarCotizacion.Visible = true;
                lbCliente.Visible = true;
                txtbxClienteCotizacion.Visible = true;
            }
            else
            {
                lbCUC.Visible = false;
                txtbxCUCCotizacion.Visible = false;
                btnValidarCotizacion.Visible = false;
                lbCliente.Visible = false;
                txtbxClienteCotizacion.Visible = false;

                txtbxCUCCotizacion.Text = "";
                txtbxClienteCotizacion.Text = "";
                lbDescuentoCotizacion.Text = "0";
                lbTotalPagarCotizacion.Text = lbTotalCotizacion.Text;
                lbAhorroCotizacion.Text = "0";
            }
        }

        private void ckbxClienteCotizacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimirCotizacion_Click(object sender, EventArgs e)
        {

        }

        private void txtbxCUCCotizacion_TextChanged(object sender, EventArgs e)
        {
            if (txtbxCUCCotizacion.TextLength > 0)
            {
                txtbxCUCCotizacion.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxCUCCotizacion.BackColor = Color.FromArgb(255, 224, 192);
            }
        }

        private void txtbxRecibidoCotizacion_TextChanged(object sender, EventArgs e)
        {
            if (txtbxRecibidoCotizacion.TextLength > 0)
            {
                txtbxRecibidoCotizacion.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxRecibidoCotizacion.BackColor = Color.FromArgb(255, 224, 192);
            }
        }
    }
}