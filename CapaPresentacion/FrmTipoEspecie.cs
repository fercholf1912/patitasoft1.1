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
    public partial class FrmTipoEspecie : Form
    {
        public FrmTipoEspecie()
        {
            InitializeComponent();
        }

        private void listar()
        {
            try
            {
                dgvListado.DataSource = NTipoEspecie.Listar();
                this.formato();
                //this.limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscar()
        {
            try
            {
                if(txtBuscar.Text != "Ingrese su busqueda...")
                {
                    dgvListado.DataSource = NTipoEspecie.Buscar(txtBuscar.Text);
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
          


            dgvListado.Columns[1].Width = 100;
            dgvListado.Columns[2].Width = 400;
            

            dgvListado.Columns[1].HeaderText = "NOMBRE";
            dgvListado.Columns[2].HeaderText = "DESCRIPCIÓN";
            

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
        private void FrmTipoEspecie_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            VariablesGlobales.id_tipo_especie = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_tipo_especie"].Value);
            VariablesGlobales.te_nombre= Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            VariablesGlobales.te_descripcion = Convert.ToString(dgvListado.CurrentRow.Cells["descripcion"].Value);

            FrmTipoEspecieA frm = new FrmTipoEspecieA();
            frm.FormClosed += new FormClosedEventHandler(FrmTipoEspecie_FormClosed);
            frm.ShowDialog();
        }

        private void FrmTipoEspecie_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmTipoEspecieI frm = new FrmTipoEspecieI();
            frm.FormClosed += new FormClosedEventHandler(FrmTipoEspecie_FormClosed);
            frm.ShowDialog();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar();
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
    }
}
