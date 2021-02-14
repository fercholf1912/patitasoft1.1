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
    public partial class FrmUsuarioA : Form
    {
        public FrmUsuarioA()
        {
            InitializeComponent();
        }
        int id_usuario;
        private void mensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void mensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FrmUsuarioA_Load(object sender, EventArgs e)
        {
            id_usuario = VariablesGlobales.id_usuario;

            switch (VariablesGlobales.usu_rol)
            {
                case "Secretario(a)":
                    cbbRol.Text = "Secretario(a)";
                    break;
                case "Administrador(a)":
                    cbbRol.Text  = "Administrador(a)";
                    break;
            }

            if(VariablesGlobales.usu_genero=="Femenino")
            {
                rbtFemenino.Checked = true;
            }
            else
            {
                rbtMasculino.Checked = true;

            }
            txtCedula.Text = VariablesGlobales.usu_cedula;
            txtNombre.Text = VariablesGlobales.usu_nombre;
            txtDireccion.Text = VariablesGlobales.usu_direccion;
            txtTelefono.Text = VariablesGlobales.usu_telefono;
            txtCorreo.Text = VariablesGlobales.usu_correo;
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

                    Rpta = NPersona.Actualizar(id_usuario, txtCedula.Text.Trim(), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text, genero, cbbRol.Text, txtCorreo.Text, txtClave.Text);
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
