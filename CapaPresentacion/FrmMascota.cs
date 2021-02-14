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
    public partial class FrmMascota : Form
    {
        public FrmMascota()
        {
            InitializeComponent();
        }

        private void listar()
        {
            try
            {
                dgvListado.DataSource = NMascota.Listar();
                this.formato();
                //this.limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
        private void Buscar()
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

        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmMascota_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void FrmMascota_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmMascotaI frm = new FrmMascotaI();
            frm.FormClosed += new FormClosedEventHandler(FrmMascota_FormClosed);
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            VariablesGlobales.id_mascota = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_mascota"].Value);
            VariablesGlobales.mas_id_propeitario = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_propietario"].Value);
            VariablesGlobales.mas_id_tipo_especie = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_tipo_especie"].Value);
            VariablesGlobales.mas_id_raza = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_raza"].Value);

            VariablesGlobales.mas_nombre = Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            VariablesGlobales.mas_genero = Convert.ToString(dgvListado.CurrentRow.Cells["genero"].Value);
            VariablesGlobales.mas_fecha_nacimiento = Convert.ToDateTime(dgvListado.CurrentRow.Cells["fecha_nacimiento"].Value);
            VariablesGlobales.mas_color = Convert.ToString(dgvListado.CurrentRow.Cells["color"].Value);


            FrmMascotaA frm = new FrmMascotaA();
            frm.FormClosed += new FormClosedEventHandler(FrmMascota_FormClosed);
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_mascota"].Value);
            string nombre = Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar a la mascota: \"" + nombre + "\"?", "PatitaSoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {

                    string Rpta = "";

                    Rpta = NMascota.Eliminar(id);

                    if (Rpta == "OK")
                    {
                        this.mensajeOK("Se elimino a la mascota.");
                        this.listar();
                    }
                    else
                    {
                        this.mensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
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
