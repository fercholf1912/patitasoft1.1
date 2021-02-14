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
    public partial class FrmTipoEspecieI : Form
    {
        public FrmTipoEspecieI()
        {
            InitializeComponent();
        }
        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmTipoEspecieI_Load(object sender, EventArgs e)
        {

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
                    Rpta = NTipoEspecie.Insertar(txtNombre.Text.Trim(), txtDescripcion.Text.Trim());
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
    }
}
