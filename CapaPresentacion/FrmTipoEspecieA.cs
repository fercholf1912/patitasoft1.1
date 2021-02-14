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
    public partial class FrmTipoEspecieA : Form
    {
        public FrmTipoEspecieA()
        {
            InitializeComponent();
        }
        int id_tipo_especie;
        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmTipoEspecieA_Load(object sender, EventArgs e)
        {
            id_tipo_especie = VariablesGlobales.id_tipo_especie;
            txtNombre.Text = VariablesGlobales.te_nombre;
            txtDescripcion.Text = VariablesGlobales.te_descripcion;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
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
                    Rpta = NTipoEspecie.Actualizar(id_tipo_especie, txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
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
