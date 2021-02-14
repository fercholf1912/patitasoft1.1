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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void cargarUsuario()
        {
            try
            {
                cboEmail.DataSource = NPersona.SeleccionarUsuario();
                cboEmail.ValueMember = "id_persona";
                cboEmail.DisplayMember = "correo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.cargarUsuario();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla = NPersona.Login(cboEmail.Text, txtClave.Text.Trim());
                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El Correo o la clave es incorrecta.", "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                        this.Hide();
                        FrmPrincipal frm = new FrmPrincipal();
                        VariablesGlobales.id_usuario_login = Convert.ToInt32(tabla.Rows[0][1]);
                        VariablesGlobales.rol_usuario_login= Convert.ToString(tabla.Rows[0][2]);
                        VariablesGlobales.nombre_usuario_login = Convert.ToString(tabla.Rows[0][3]);
                        frm.Show();
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    DataTable tabla = new DataTable();
                    tabla = NPersona.Login(cboEmail.Text, txtClave.Text.Trim());
                    if (tabla.Rows.Count <= 0)
                    {
                        MessageBox.Show("El Correo o la clave es incorrecta.", "PatitaSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                            FrmPrincipal frm = new FrmPrincipal();
                            VariablesGlobales.id_usuario_login = Convert.ToInt32(tabla.Rows[0][1]);
                            VariablesGlobales.rol_usuario_login = Convert.ToString(tabla.Rows[0][2]);
                            VariablesGlobales.nombre_usuario_login = Convert.ToString(tabla.Rows[0][3]);
                            this.Hide();
                            frm.Show();
                        
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
