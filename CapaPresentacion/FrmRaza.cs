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
    public partial class FrmRaza : Form
    {
        public FrmRaza()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgvListado.DataSource = NRaza.Listar();
                this.formato();
                //this.limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                if(txtBuscar.Text != "Ingrese su busqueda...")
                {
                    dgvListado.DataSource = NRaza.Buscar(txtBuscar.Text);
                    this.formato();
                    //this.limpiar();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void formato()
        {
            dgvListado.Columns[0].Visible = false;
            


            dgvListado.Columns[1].Width = 200;
            dgvListado.Columns[2].Width = 200;
            dgvListado.Columns[3].Width = 100;
           

            dgvListado.Columns[1].HeaderText = "RAZA";
            dgvListado.Columns[2].HeaderText = "ESPECIE";
            dgvListado.Columns[3].HeaderText = "PELIGROSIDAD";
            ;

            //dgvListado.Columns[11].HeaderText = "P. CREDITO";
            //dgvListado.Columns[14].HeaderText = "ESTADO";

            //dgvListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvListado.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvListado.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmRaza_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            VariablesGlobales.id_raza = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_raza"].Value);
            VariablesGlobales.raz_id_tipo_especie = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_tipo_especie"].Value);
            VariablesGlobales.raz_nombre = Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            VariablesGlobales.raz_peligrosidad = Convert.ToString(dgvListado.CurrentRow.Cells["peligrosidad"].Value);
          

            FrmRazaA frm = new FrmRazaA();
            frm.FormClosed += new FormClosedEventHandler(FrmRaza_FormClosed);
            frm.ShowDialog();
        }

        private void FrmRaza_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmRazaI frm = new FrmRazaI();
            frm.FormClosed += new FormClosedEventHandler(FrmRaza_FormClosed);
            frm.ShowDialog();
        }

        private void txtBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscar.Text = "";
            txtBuscar.ForeColor = Color.Black;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "Ingrese su busqueda...";
            txtBuscar.ForeColor = Color.DimGray;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}


