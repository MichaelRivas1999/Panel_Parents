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
    public partial class AgregarGrupoClases : Form
    {
        public AgregarGrupoClases()
        {
            InitializeComponent();
        }

        private void AgregarGrupoClases_Load(object sender, EventArgs e)
        {
                lblGrupoClase.Parent = pictureBox1;
                lblGrupoClase.BackColor = Color.Transparent;
                lblGrupoClase.ForeColor = Color.White;
                lblAño.Parent = pictureBox1;
                lblAño.BackColor = Color.Transparent;
                lblAño.ForeColor = Color.White;
                lblGrado.Parent = pictureBox1;
                lblGrado.BackColor = Color.Transparent;
                lblGrado.ForeColor = Color.White;
                lblMaestro.Parent = pictureBox1;
                lblMaestro.BackColor = Color.Transparent;
                lblMaestro.ForeColor = Color.White;
                lblAsignatura.Parent = pictureBox1;
                lblAsignatura.BackColor = Color.Transparent;
                lblAsignatura.ForeColor = Color.White;
                
        }
    }
}
