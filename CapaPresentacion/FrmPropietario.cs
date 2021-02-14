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
    public partial class FrmPropietario : Form
    {
        public FrmPropietario()
        {
            InitializeComponent();
        }
        private void listar()
        {
            try
            {
                dgvListado.DataSource = NPersona.ListarPropietario();
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
                    dgvListado.DataSource = NPersona.BuscarPropietario(txtBuscar.Text);
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
            dgvListado.Columns[2].Width = 200;
            dgvListado.Columns[3].Width = 300;
            dgvListado.Columns[4].Width = 100;
            dgvListado.Columns[5].Width = 100;


            dgvListado.Columns[1].HeaderText = "CÉDULA";
            dgvListado.Columns[2].HeaderText = "NOMBRE";
            dgvListado.Columns[3].HeaderText = "DIRECCIÓN";
            dgvListado.Columns[4].HeaderText = "TELÉFONO";
            dgvListado.Columns[5].HeaderText = "GÉNERO";
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
        private void FrmPropietario_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void FrmPropietario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmPropietarioI frm = new FrmPropietarioI();
            frm.FormClosed += new FormClosedEventHandler(FrmPropietario_FormClosed);
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            VariablesGlobales.pro_id_persona = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_persona"].Value);
            
            VariablesGlobales.pro_cedula = Convert.ToString(dgvListado.CurrentRow.Cells["cedula"].Value);
            VariablesGlobales.pro_nombre = Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            VariablesGlobales.pro_direccion = Convert.ToString(dgvListado.CurrentRow.Cells["direccion"].Value);
            VariablesGlobales.pro_telefono = Convert.ToString(dgvListado.CurrentRow.Cells["telefono"].Value);
            
            VariablesGlobales.pro_genero = Convert.ToString(dgvListado.CurrentRow.Cells["genero"].Value);

            FrmPropietarioA frm = new FrmPropietarioA();
            frm.FormClosed += new FormClosedEventHandler(FrmPropietario_FormClosed);
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvListado.CurrentRow.Cells["id_persona"].Value);
            string nombre = Convert.ToString(dgvListado.CurrentRow.Cells["nombre"].Value);
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar al propietario: \"" + nombre + "\"?", "PatitaSoft", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {

                    string Rpta = "";

                    Rpta = NPersona.Eliminar(id);

                    if (Rpta == "OK")
                    {
                        this.mensajeOK("Se elimino el propietario.");
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
            Buscar();
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
