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
    public partial class ListadoGrupoClase : Form
    {
        public ListadoGrupoClase()
        {
            InitializeComponent();
        }

        private void EstilizarEncabezado()
        {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Arial", 13, FontStyle.Bold);
            columnHeaderStyle.BackColor = Color.Black;
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dg_GrupoClase.BackgroundColor = Color.White;

            Dg_GrupoClase.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void ListadoGrupoClase_Load(object sender, EventArgs e)
        {
            lblListado.Parent = pictureBox1;
            lblListado.BackColor = Color.Transparent;
            lblListado.ForeColor = Color.White;
            lblBuscar.Parent = pictureBox1;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.ForeColor = Color.White;
        }
    }
}
