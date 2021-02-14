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
    public partial class FrmMascotaI : Form
    {
        public FrmMascotaI()
        {
            InitializeComponent();
        }

        private void cargarPropietario()
        {
            try
            {
                cbbPropietario.DataSource = NPersona.SeleccionarPropietario();
                cbbPropietario.ValueMember = "id_propietario";
                cbbPropietario.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
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
        private void cargarRaza()
        {
            try
            {
                cbbRaza.DataSource = NRaza.Seleccionar(Convert.ToInt32(cbbEspecie.SelectedValue));
                cbbRaza.ValueMember = "id_raza";
                cbbRaza.DisplayMember = "nombre";
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
        private void FrmMascotaI_Load(object sender, EventArgs e)
        {
            this.cargarPropietario();
            this.cargarTipoEspecie();
        }
        int cont = 0;
        private void cbbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cont > 1)
            this.cargarRaza();
            cont += 1;
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
                    string genero;
                    if (rbtHembra.Checked) genero = "Hembra"; else genero = "Macho";

                    Rpta = NMascota.Insertar(Convert.ToInt32(cbbPropietario.SelectedValue), Convert.ToInt32(cbbEspecie.SelectedValue), Convert.ToInt32(cbbRaza.SelectedValue),txtNombre.Text, genero, dtpFechaNacimiento.Value,cbbColor.Text);
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
