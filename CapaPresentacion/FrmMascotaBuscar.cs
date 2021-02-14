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
    public partial class FrmMascotaBuscar : Form
    {
        public FrmMascotaBuscar()
        {
            InitializeComponent();
        }
        private void buscar()
        {
            try
            {
                if(txtBuscar.Text != "Ingrese su busqueda...")
                {
                    dgvListado.DataSource = NMascota.Buscar(txtBuscar.Text);
                    this.formato();
                    //this.limpiar();
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmMascotaBuscar_Load(object sender, EventArgs e)
        {

        }
        private void formato()
        {
            dgvListado.Columns[0].Visible = false;
            dgvListado.Columns[1].Visible = false;
            dgvListado.Columns[2].Visible = false;
            dgvListado.Columns[3].Visible = false;


            dgvListado.Columns[4].Width = 200;
            dgvListado.Columns[5].Width = 100;
            dgvListado.Columns[6].Width = 100;
            dgvListado.Columns[7].Width = 100;
            dgvListado.Columns[8].Width = 100;
            dgvListado.Columns[9].Width = 100;
            dgvListado.Columns[10].Width = 200;


            dgvListado.Columns[4].HeaderText = "NOMBRE";
            dgvListado.Columns[5].HeaderText = "ESPECIE";
            dgvListado.Columns[6].HeaderText = "RAZA";
            dgvListado.Columns[7].HeaderText = "GÉNERO";
            dgvListado.Columns[8].HeaderText = "EDAD";
            dgvListado.Columns[9].HeaderText = "COLOR";
            dgvListado.Columns[10].HeaderText = "PROPIETARIO";

            //dgvListado.Columns[11].HeaderText = "P. CREDITO";
            //dgvListado.Columns[14].HeaderText = "ESTADO";

            //dgvListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvListado.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvListado.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            VariablesGlobales.con_id_mascota = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_mascota"].Value);
            VariablesGlobales.con_nombre = Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            FrmControl frm = new FrmControl();
            //frm.FormClosed += new FormClosedEventHandler(FrmPropietario_FormClosed);
            //this.Close();
            frm.Show();
            //this.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
