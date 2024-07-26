using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Negocio.Maestro;
using System.Net.Http;
using Newtonsoft.Json;
using Panel_Parents;

namespace Panel_Parents
{
    public partial class ListadoMaestros : Form
    {
        private readonly Maestro_Metod _maestroMetod = new Maestro_Metod();
        private List<Maestro> maestros;

        public ListadoMaestros()
        {
            InitializeComponent();
            comboBoxMaestros.SelectedIndexChanged += comboBoxMaestros_SelectedIndexChanged;
        }

        private async void ListadoMaestros_Load(object sender, EventArgs e)
        {
            lblListado.Parent = pictureBox1;
            lblListado.BackColor = Color.Transparent;
            lblListado.ForeColor = Color.White;
            lblBuscar.Parent = pictureBox1;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.ForeColor = Color.White;

            await CargarMaestros();
            AjustarTamañoColumnas();
            EstilizarEncabezado();
            AjustarTamañoFilas();
            ConfigurarColorFondo();
            ConfigurarSoloLectura();
        }

        public static class GlobalData
        {
            public static string Token { get; set; }
        }
        private async Task CargarMaestros()
        {
            string apiUrl = "http://panelparent.somee.com/api/maestro/listarmaestro";
            string token = GlobalData.Token; // Obtener el token desde la clase estática

            // Verificar el token antes de enviarlo
            if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("El token está vacío o es nulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show($"El token es: {token}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                maestros = await _maestroMetod.ObtenerMaestrosAsync(apiUrl, token);
                Dg_Maestro.DataSource = maestros;

                comboBoxMaestros.DataSource = maestros;
                comboBoxMaestros.DisplayMember = "Nombre"; // Asegúrate de usar el nombre correcto de la propiedad del objeto Maestro
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Error de autenticación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error al conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AjustarTamañoColumnas()
        {
            Dg_Maestro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn column in Dg_Maestro.Columns)
            {
                if (column.Name != "Id")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            Dg_Maestro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void AjustarTamañoFilas()
        {
            Dg_Maestro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void EstilizarEncabezado()
        {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                Font = new Font("Arial", 13, FontStyle.Bold),
                BackColor = Color.Black,
                ForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            Dg_Maestro.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
        }

        private void ConfigurarColorFondo()
        {
            Dg_Maestro.BackgroundColor = Color.White;
        }

        private void ConfigurarSoloLectura()
        {
            Dg_Maestro.ReadOnly = true;
        }

        private void comboBoxMaestros_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMaestro = (Maestro)comboBoxMaestros.SelectedItem;
            if (selectedMaestro != null)
            {
                foreach (DataGridViewRow row in Dg_Maestro.Rows)
                {
                    var maestro = (Maestro)row.DataBoundItem;
                    if (maestro.Id == selectedMaestro.Id)
                    {
                        row.Selected = true;
                        Dg_Maestro.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
    }
}
