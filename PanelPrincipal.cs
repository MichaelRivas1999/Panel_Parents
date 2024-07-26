using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_Parents
{
    public partial class PanelPrincipal : Form
    {
        public PanelPrincipal()
        {
            InitializeComponent();
            customizeDesing();
            hideSubMenu();
        }


        #region Ocultar el Panel de SubMenu
        private void customizeDesing()
        {

            pnlSubMenuMaestros.Visible = false;
            pnlSubMenuEstudiantes.Visible = false;
            pnlSubMenuPadres.Visible = false;
            pnlSubMenuGrupoClases.Visible = false;
            pnlSubMenuAsignatura.Visible = false;
            pnlSubMenuAnuncio.Visible = false;
        }
        #endregion

        #region Visualizar SubMenu al darle Clic
        private void hideSubMenu()
        {
            if (pnlSubMenuMaestros.Visible == true)
                pnlSubMenuMaestros.Visible = false;
            if (pnlSubMenuEstudiantes.Visible == true)
                pnlSubMenuEstudiantes.Visible = false;
            if (pnlSubMenuPadres.Visible == true)
                pnlSubMenuPadres.Visible = false;
            if (pnlSubMenuGrupoClases.Visible == true)
                pnlSubMenuGrupoClases.Visible = false;
            if (pnlSubMenuAsignatura.Visible == true)
                pnlSubMenuAsignatura.Visible = false;
            if (pnlSubMenuAnuncio.Visible == true)
                pnlSubMenuAnuncio.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }

            else
                subMenu.Visible = false;
        }
        #endregion

        #region Activar los Formularios Hijos
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        #region SubMenu Maestro
        private void btnDocente_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuMaestros);
        }

        private void btnAgregarMaestro_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarMaestro());
            hideSubMenu();
        }

        private void btnListadoMaestro_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoMaestros());
            hideSubMenu();
        }

        private void btnGrupoDeClase_Click(object sender, EventArgs e)
        {
            openChildForm(new GrupoClaseMaestros());
            hideSubMenu();
        }
        #endregion

        #region SubMenu Estudiantes
        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuEstudiantes);
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarEstudiantes());
            hideSubMenu();
        }

        private void btnListadoEstudiante_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoEstudiantes());
            hideSubMenu();
        }

        private void btnAsignaturasEstudiantes_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoAsignaturaEstudiantes());
            hideSubMenu();
        }
        #endregion

        #region SubMenu Padres
        private void btnPadres_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuPadres);
        }

        private void btnAgregarPadres_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarPadres());
            hideSubMenu();
        }

        private void btnListadoPadres_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoPadres());
            hideSubMenu();
        }
        #endregion

        #region SubMenu Grupo de Clase
        private void btnGrupoClases_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuGrupoClases);
        }

        private void btnAgregarGrupoClase_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarGrupoClases());
            hideSubMenu();
        }

        private void btnListadoGrupoClase_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoGrupoClase());
            hideSubMenu();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            openChildForm(new AsignarGrupoClase());
            hideSubMenu();
        }
        #endregion

        #region SubMenu Asignatura
        private void btnAsignatura_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuAsignatura);
        }

        private void btnAgregarAsignatura_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarAsignatura());
            hideSubMenu();
        }

        private void btnListadoAsignatura_Click(object sender, EventArgs e)
        {
            openChildForm(new ListadoAsignatura());
            hideSubMenu();
        }
        #endregion

        #region SubMenu Anuncio
        private void btnAnuncio_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuAnuncio);
        }

        private void btnAgregarAnuncio_Click(object sender, EventArgs e)
        {
            openChildForm(new AgregarAnuncio());
            hideSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new VerAvisos());
            hideSubMenu();
        }

        #endregion



        #region Cerrar Sesión

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        #endregion

        private void pictureBox2_Resize(object sender, EventArgs e)
        {

        }

        
    }
}
