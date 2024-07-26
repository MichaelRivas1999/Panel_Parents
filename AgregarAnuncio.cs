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
    public partial class AgregarAnuncio : Form
    {
        public AgregarAnuncio()
        {
            InitializeComponent();
            ConfigurarTextBox();
           

        }

        private void ConfigurarTextBox()
        {
            textBox2 = new TextBox();
            textBox2.Location = new Point(50, 50);
            textBox2.Multiline = true; // Permite múltiples líneas de texto
            textBox2.ScrollBars = ScrollBars.Vertical; // Barra de desplazamiento vertical
            textBox2.Size = new Size(300, 200);
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right; // Ajusta al tamaño del formulario
            this.Controls.Add(textBox2); // Agrega el control al formulario


        }
        
        
       

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void AgregarAnuncio_Load(object sender, EventArgs e)
        {
            lblAnuncio.Parent = pictureBox1;
            lblAnuncio.BackColor = Color.Transparent;
            lblAnuncio.ForeColor = Color.White;
            lblAsunto.Parent = pictureBox1;
            lblAsunto.BackColor = Color.Transparent;
            lblAsunto.ForeColor = Color.White;
            lblFecha.Parent = pictureBox1;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.ForeColor = Color.White;
            lblDescripcion.Parent = pictureBox1;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.ForeColor = Color.White;

        }
    }
}
