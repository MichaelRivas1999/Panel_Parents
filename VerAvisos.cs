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
    public partial class VerAvisos : Form
    {
        public VerAvisos()
        {
            InitializeComponent();
        }

        private void VerAvisos_Load(object sender, EventArgs e)
        {
            //Aqui podes mostrar solamente el asunto del aviso, la descripcion y fecha
            //que vence por ejemplo del mismo aviso sin necesidad de ingresar el Id
            //y demas que puedan haber.

            lblAvisos.Parent = pictureBox1;
            lblAvisos.BackColor = Color.Transparent;
            lblAvisos.ForeColor = Color.White;
            lblBuscar.Parent = pictureBox1;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.ForeColor = Color.White;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Arial", 13, FontStyle.Bold);
            columnHeaderStyle.BackColor = Color.Black;
            columnHeaderStyle.ForeColor = Color.White;
            columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           
           
        }
    }
}
