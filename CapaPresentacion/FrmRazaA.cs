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
    public partial class FrmRazaA : Form
    {
        public FrmRazaA()
        {
            InitializeComponent();
        }

        int id_raza;


        private void cargarTipoEspecie()
        {
            try
            {
                cbbEspecie.DataSource = NTipoEspecie.Seleccionar();
                cbbEspecie.ValueMember = "id_tipo_especie";
                cbbEspecie.DisplayMember = "nombre";
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
        private void FrmRazaA_Load(object sender, EventArgs e)
        {
            this.cargarTipoEspecie();
            id_raza = VariablesGlobales.id_raza;
            txtNombre.Text = VariablesGlobales.raz_nombre;
            cbbEspecie.SelectedValue = VariablesGlobales.raz_id_tipo_especie;
            cbbPeligrosidad.Text = VariablesGlobales.raz_peligrosidad;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtNombre.Text == string.Empty)
                {
                    this.mensajeError("Falta Ingresar algunos datos importantes.");

                    //errorIcono.SetError(txtStock, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NRaza.Actualizar(id_raza,Convert.ToInt32(cbbEspecie.SelectedValue), txtNombre.Text, cbbPeligrosidad.Text);
                    if (Rpta == "OK")
                    {
                        this.mensajeOK("Se actualizo de forma correcta el registro.");
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
    }
}
