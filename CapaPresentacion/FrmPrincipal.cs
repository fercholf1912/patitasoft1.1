using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void gestionarPropietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPropietario frm = new FrmPropietario();
            frm.MdiParent = this;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void gestionarMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMascota frm = new FrmMascota();
            frm.MdiParent = this;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void gestionarEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoEspecie frm = new FrmTipoEspecie();
            frm.MdiParent = this;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void gestionarRazasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaza frm = new FrmRaza();
            frm.MdiParent = this;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void gestionarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void nuevoControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMascotaBuscar frm = new FrmMascotaBuscar();
            frm.MdiParent = this;
            frm.MaximizeBox = false;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = VariablesGlobales.nombre_usuario_login + "(" + VariablesGlobales.rol_usuario_login + ")";
            try
            {
                this.BackgroundImageLayout = ImageLayout.Stretch;

                this.BackgroundImage = Properties.Resources.LOGO;
                this.BackColor = Color.White;

            }
            catch (InvalidCastException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
