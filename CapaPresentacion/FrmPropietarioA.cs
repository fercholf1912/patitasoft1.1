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
    public partial class FrmPropietarioA : Form
    {
        public FrmPropietarioA()
        {
            InitializeComponent();
        }
        //Variables
        int id_persona;

        //Variables
        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void FrmPropietarioA_Load(object sender, EventArgs e)
        {
            id_persona = VariablesGlobales.pro_id_persona;

            
            

            if (VariablesGlobales.pro_genero == "Femenino")
            {
                rbtFemenino.Checked = true;
            }
            else
            {
                rbtMasculino.Checked = true;

            }
            txtCedula.Text = VariablesGlobales.pro_cedula;
            txtNombre.Text = VariablesGlobales.pro_nombre;
            txtDireccion.Text = VariablesGlobales.pro_direccion;
            txtTelefono.Text = VariablesGlobales.pro_telefono;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtCedula.Text == string.Empty)
                {
                    this.mensajeError("Falta Ingresar algunos datos importantes.");

                    //errorIcono.SetError(txtStock, "Ingrese un nombre.");
                }
                else
                {
                    string genero;
                    if (rbtFemenino.Checked) genero = "Femenino"; else genero = "Masculino";

                    Rpta = NPersona.Actualizar(id_persona, txtCedula.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text, genero);
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
