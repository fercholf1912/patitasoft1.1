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
    public partial class FrmMascotaA : Form
    {
        public FrmMascotaA()
        {
            InitializeComponent();
        }
        int id_mascota;
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
        private void FrmMascotaA_Load(object sender, EventArgs e)
        {
            id_mascota = VariablesGlobales.id_mascota;
            this.cargarPropietario();
            this.cargarTipoEspecie();
            this.cargarRaza();

            cbbPropietario.SelectedValue = VariablesGlobales.mas_id_propeitario;
            cbbEspecie.SelectedValue = VariablesGlobales.mas_id_tipo_especie;
            cbbRaza.SelectedValue = VariablesGlobales.mas_id_raza;
            txtNombre.Text = VariablesGlobales.mas_nombre;
            if(VariablesGlobales.mas_genero=="Hembra")
            {
                rbtHembra.Checked = true;

            }
            else
            {
                rbtMacho.Checked = true;
            }
            dtpFechaNacimiento.Value = VariablesGlobales.mas_fecha_nacimiento;
            cbbColor.Text = VariablesGlobales.mas_color;
        }

        private void cbbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarRaza();
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
                    string genero;
                    if (rbtHembra.Checked) genero = "Hembra"; else genero = "Macho";

                    Rpta = NMascota.Actualizar(id_mascota,Convert.ToInt32(cbbPropietario.SelectedValue), Convert.ToInt32(cbbEspecie.SelectedValue), Convert.ToInt32(cbbRaza.SelectedValue), txtNombre.Text, genero, dtpFechaNacimiento.Value, cbbColor.Text);
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
