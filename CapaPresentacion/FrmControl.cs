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
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
        }
        private Validacion v = new Validacion();
        int id_mascota;
        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private DataTable DtVacuna = new DataTable();
        private void crearTabla()
        {
            this.DtVacuna.Columns.Add("nombre", System.Type.GetType("System.String"));
            this.DtVacuna.Columns.Add("dosis", System.Type.GetType("System.String"));
            this.DtVacuna.Columns.Add("descripcion", System.Type.GetType("System.String"));
            

            dgvVacunas.DataSource = this.DtVacuna;

            //dgvDetalle.Columns[0].Visible = false;
            
            //dgvDetalle.Columns[6].ReadOnly = true;
            

            dgvVacunas.Columns[0].HeaderText = "VACUNA";
            dgvVacunas.Columns[1].HeaderText = "DOSIS";
            dgvVacunas.Columns[2].HeaderText = "DESCRIPCIÓN";
            

            //dgvDetalle.Columns[0].Width = 60;
            //dgvDetalle.Columns[2].Width = 80;
            //dgvDetalle.Columns[3].Width = 300;
            

        }
        private void agregarVacuna(String nombre, string dosis, string descripcion)
        {
            bool Agregar = true;
            if (Agregar)
            {
                DataRow fila = DtVacuna.NewRow();
                fila["nombre"] = nombre;
                fila["dosis"] = dosis;
                fila["descripcion"] = descripcion;
                this.DtVacuna.Rows.Add(fila);
            }
        }
        private void listar()
        {
            try
            {
                dgvListado.DataSource = NControl.Listar(VariablesGlobales.con_id_mascota);
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


            dgvListado.Columns[3].Width = 200;
            dgvListado.Columns[4].Width = 100;
            dgvListado.Columns[5].Width = 100;
            dgvListado.Columns[6].Width = 100;
            

            dgvListado.Columns[3].HeaderText = "VETERINARIO";
            dgvListado.Columns[4].HeaderText = "FECHA";
            dgvListado.Columns[5].HeaderText = "PESO";
            dgvListado.Columns[6].HeaderText = "TALLA";

           


            //dgvListado.Columns[11].HeaderText = "P. CREDITO";
            //dgvListado.Columns[14].HeaderText = "ESTADO";

            //dgvListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvListado.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvListado.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        private void llblCerrarAgragarVacuna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneAgregarVacuna.Visible = false;
            txtVacuna.Text = "Escriba una observación...";
            txtVacuna.ForeColor = Color.DimGray;
        }

        private void lblAgregarVacuna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            paneAgregarVacuna.Visible = true;
        }

        private void paneAgregarVacuna_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            crearTabla();
            this.listar();
            id_mascota = VariablesGlobales.con_id_mascota;
            gbxNuevoControl.Text = "Nuevo Control para la mascota " + VariablesGlobales.con_nombre;

        }

        private void lblAgregar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.agregarVacuna(cbbNombreVacuna.Text,cbbDosis.Text,txtVacuna.Text);
            paneAgregarVacuna.Visible = false;
            txtVacuna.Text = "Escriba una observación...";
            txtVacuna.ForeColor = Color.DimGray;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtPeso.Text == string.Empty)
                {
                    this.mensajeError("Falta Ingresar algunos datos importantes.");

                    //errorIcono.SetError(txtStock, "Ingrese un nombre.");
                }
                else
                {
                    //string genero;
                    //if (rbtFemenino.Checked) genero = "Femenino"; else genero = "Masculino";

                    Rpta = NControl.Insertar(id_mascota,VariablesGlobales.id_usuario_login,Convert.ToDecimal(txtPeso.Text),Convert.ToDecimal(txtTalla.Text),"Insertar Imagen",Convert.ToString(txtVacuna.Text),DtVacuna);
                    if (Rpta == "OK")
                    {
                        this.mensajeOK("Se inserto de forma correcta el registro.");
                        this.Close();
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

        private void txtPeso_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPeso.TextLength == 4)
            {
                this.txtPeso.Select(0, 1);
            }
            if (txtPeso.TextLength == 5)
            {
                this.txtPeso.Select(0, 2);
            }
            if (txtPeso.TextLength == 6)
            {
                this.txtPeso.Select(0, 3);
            }
            if (txtPeso.TextLength == 7)
            {
                this.txtPeso.Select(0, 4);
            }
            if (txtPeso.TextLength == 8)
            {
                this.txtPeso.Select(0, 5);
            }
        }

        private void txtTalla_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtTalla.TextLength == 4)
            {
                this.txtTalla.Select(0, 1);
            }
            if (txtTalla.TextLength == 5)
            {
                this.txtTalla.Select(0, 2);
            }
            if (txtTalla.TextLength == 6)
            {
                this.txtTalla.Select(0, 3);
            }
            if (txtTalla.TextLength == 7)
            {
                this.txtTalla.Select(0, 4);
            }
            if (txtTalla.TextLength == 8)
            {
                this.txtTalla.Select(0, 5);
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.soloNumeros(e);
        }

        private void txtObservacion_MouseClick(object sender, MouseEventArgs e)
        {
            txtObservacion.Text = "";
            txtObservacion.ForeColor = Color.Black;
        }

        private void txtObservacion_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtVacuna_MouseClick(object sender, MouseEventArgs e)
        {
            txtVacuna.Text = "";
            txtVacuna.ForeColor = Color.Black;
        }

        
    }
}
