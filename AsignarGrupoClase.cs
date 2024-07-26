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
    public partial class AsignarGrupoClase : Form
    {
        public AsignarGrupoClase()
        {
            InitializeComponent();
        }

        private void AsignarGrupoClase_Load(object sender, EventArgs e)
        {
            lblAsignar.Parent = pictureBox1;
            lblAsignar.BackColor = Color.Transparent;
            lblAsignar.ForeColor = Color.White;
            lblGrupo.Parent = pictureBox1;
            lblGrupo.BackColor = Color.Transparent;
            lblGrupo.ForeColor = Color.White;
            lblMateria.Parent = pictureBox1;
            lblMateria.BackColor = Color.Transparent;
            lblMateria.ForeColor = Color.White;
            lblPMaestro.Parent = pictureBox1;
            lblPMaestro.BackColor = Color.Transparent;
            lblPMaestro.ForeColor = Color.White;
        }
    }
}
