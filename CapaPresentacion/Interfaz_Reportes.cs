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
    public partial class interfaz_Reportes : Form
    {

        public interfaz_Reportes()
        {
            InitializeComponent();
        }

        private void MostrarCompras()
        {
            this.dtgvCompras.DataSource = NReportes.MostrarCompras();
        }

        private void MostrarVentas()
        {
            this.dtgvVentas.DataSource = NReportes.MostrarVentas();
        }

        private void BuscarCompras()
        {

            if (dtpkFechaInicioCompra.Value.CompareTo(this.dtpkFechaFinalCompra.Value) == 1) //VALIDACION DE QUE FECHA INICIO NO SEA MAYOR A FECHA FINAL
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.dtgvCompras.DataSource = NReportes.BuscarCompras(dtpkFechaInicioCompra.Value.ToString("yyyy-MM-dd"), dtpkFechaFinalCompra.Value.ToString("yyyy-MM-dd"));
            }

        }

        private void BuscarVentas()
        {
            if (dtpkFechaInicioVenta.Value.CompareTo(this.dtpkFechaFinalVenta.Value) == 1) //VALIDACION DE QUE FECHA INICIO NO SEA MAYOR A FECHA FINAL
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                this.dtgvVentas.DataSource = NReportes.BuscarVentas(dtpkFechaInicioVenta.Value.ToString("yyyy-MM-dd"), dtpkFechaFinalVenta.Value.ToString("yyyy-MM-dd"));
            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.MostrarCompras();
            this.MostrarVentas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCompras_Click(object sender, EventArgs e)
        {
            this.BuscarCompras();

            int total = 0;
            foreach (DataGridViewRow row in dtgvCompras.Rows)
            {
                total += Convert.ToInt32(row.Cells["costo"].Value);
            }
            lbTotalCompras.Text = "$" + Convert.ToString(total) + ".00";
        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            this.BuscarVentas();
            
            int total = 0;
            foreach (DataGridViewRow row in dtgvVentas.Rows)
            {
                total += Convert.ToInt32(row.Cells["PrecioVenta"].Value);
            }
            lbTotalVentas.Text = "$" + Convert.ToString(total) + ".00";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = 0;
            int width = 0;

            Pen p = new Pen(Brushes.Black, 2.5f);

            #region FechaCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[0].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(100, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region NombreVendedorCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[1].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(100 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region TelefonoCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(200 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(200 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[2].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(200 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region DireccionFechaCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(300 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(300 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[3].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(300 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region MarcaCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(400 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(400 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[4].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(400 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region ModeloCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(500 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(500 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[5].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(500 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region AñoCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(600 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(600 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[6].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(600 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            #region PrecioCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(700 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(700 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
            e.Graphics.DrawString(dtgvCompras.Columns[7].HeaderText.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(700 + dtgvCompras.Columns[0].Width, 100, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

            #endregion

            height = 100;

            while (i < dtgvCompras.Rows.Count)
            {
                height += dtgvCompras.Rows[0].Height;
                e.Graphics.DrawRectangle(p, new Rectangle(100, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[0].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(100, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[1].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(100 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(200 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[2].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(200 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(300 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[3].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(300 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(400 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[4].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(400 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(500 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[5].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(500 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(600 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[6].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(600 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(700 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));
                e.Graphics.DrawString(dtgvCompras.Rows[i].Cells[7].FormattedValue.ToString(), dtgvCompras.Font, Brushes.Black, new Rectangle(700 + dtgvCompras.Columns[0].Width, height, dtgvCompras.Columns[0].Width, dtgvCompras.Rows[0].Height));


                i++;
            }
        }

        private void btnImprimirVenta_Click(object sender, EventArgs e)
        {
            printDocument2.Print();
        }

        private void printDocument2_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = 0;
            int width = 0;

            Pen p = new Pen(Brushes.Black, 2.5f);

            #region FechaCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[0].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(100, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            #region NombreVendedorCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(100 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(100 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[1].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(100 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            #region TelefonoCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(200 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(200 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[2].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(200 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            #region DireccionFechaCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(300 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(300 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[3].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(300 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            #region MarcaCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(400 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(400 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[4].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(400 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            #region ModeloCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(500 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(500 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[5].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(500 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            #region AñoCol
            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(600 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawRectangle(p, new Rectangle(600 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            e.Graphics.DrawString(dtgvVentas.Columns[6].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(600 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            #endregion

            //#region PrecioCol
            //e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(700 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            //e.Graphics.DrawRectangle(p, new Rectangle(700 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
            //e.Graphics.DrawString(dtgvVentas.Columns[7].HeaderText.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(700 + dtgvVentas.Columns[0].Width, 100, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

            //#endregion

            height = 100;

            while (i < dtgvVentas.Rows.Count)
            {
                height += dtgvVentas.Rows[0].Height;
                e.Graphics.DrawRectangle(p, new Rectangle(100, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[0].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(100, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(100 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[1].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(100 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(200 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[2].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(200 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(300 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[3].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(300 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(400 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[4].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(400 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(500 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[5].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(500 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                e.Graphics.DrawRectangle(p, new Rectangle(600 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[6].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(600 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                //e.Graphics.DrawRectangle(p, new Rectangle(700 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));
                //e.Graphics.DrawString(dtgvVentas.Rows[i].Cells[7].FormattedValue.ToString(), dtgvVentas.Font, Brushes.Black, new Rectangle(700 + dtgvVentas.Columns[0].Width, height, dtgvVentas.Columns[0].Width, dtgvVentas.Rows[0].Height));

                i++;
            }
        }

        private void btnSalirReportes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas a punto de salir de Reportes de compras y ventas, ¿Deseas continuar?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
