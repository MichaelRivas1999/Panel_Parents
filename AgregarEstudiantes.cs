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
    public partial class AgregarEstudiantes : Form
    {
        public AgregarEstudiantes()
        {
            InitializeComponent();
        }

        private void AgregarEstudiantes_Load(object sender, EventArgs e)
        {
            lblEstudiante.Parent = pictureBox1;
            lblEstudiante.BackColor = Color.Transparent;
            lblEstudiante.ForeColor = Color.White;
            lblPNombre.Parent = pictureBox1;
            lblPNombre.BackColor = Color.Transparent;
            lblPNombre.ForeColor = Color.White;
    
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //////////////
        }
    }
}
