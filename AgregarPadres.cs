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
    public partial class AgregarPadres : Form
    {
        public AgregarPadres()
        {
            InitializeComponent();
        }

        private void AgregarPadres_Load(object sender, EventArgs e)
        {
            lblPadres.Parent = pictureBox1;
            lblPadres.BackColor = Color.Transparent;
            lblPadres.ForeColor = Color.White;
            lblPNombre.Parent = pictureBox1;
            lblPNombre.BackColor = Color.Transparent;
            lblPNombre.ForeColor = Color.White;
            lblSNombre.Parent = pictureBox1;
            lblSNombre.BackColor = Color.Transparent;
            lblSNombre.ForeColor = Color.White;
            lblPApellido.Parent = pictureBox1;
            lblPApellido.BackColor = Color.Transparent;
            lblPApellido.ForeColor = Color.White;
            lblSApellido.Parent = pictureBox1;
            lblSApellido.BackColor = Color.Transparent;
            lblSApellido.ForeColor = Color.White;
            lblDireccion.Parent = pictureBox1;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.ForeColor = Color.White;
            lblCorreo.Parent = pictureBox1;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.ForeColor = Color.White;
            lblCelular.Parent = pictureBox1;
            lblCelular.BackColor = Color.Transparent;
            lblCelular.ForeColor = Color.White;
        }
    }
}
