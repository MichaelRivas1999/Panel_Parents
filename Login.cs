using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace Panel_Parents
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Suscribir eventos KeyDown
            txtUsuario.KeyDown += new KeyEventHandler(txtUsuario_KeyDown);
            txtContraseña.KeyDown += new KeyEventHandler(txtContraseña_KeyDown);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparm, int lparam);



        #region Botones 
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                
                //txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private async void btnIniciar_Click(object sender, EventArgs e)
        {


            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            var resultado = await ValidarCredencialesAsync(usuario, contrasena);

            if (resultado.EsValido)
            {
                // Almacenar el token en la clase GlobalData
                GlobalData.Token = resultado.Token;

                this.Hide();

                Bienvenido bienvenido = new Bienvenido(usuario);
                bienvenido.ShowDialog();

                PanelPrincipal inicio = new PanelPrincipal();
                inicio.Show();

                //MessageBox.Show(GlobalData.Token);
            }
            else
            {
                MessageBox.Show($"Usuario o contraseña incorrectos: {resultado.MensajeError}", "Vuelva a Intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        public class ValidacionResultado
        {
            public bool EsValido { get; set; }
            public string Token { get; set; }
            public string MensajeError { get; set; }
        }

        public static class GlobalData
        {
            public static string Token { get; set; }
        }
        private async Task<ValidacionResultado> ValidarCredencialesAsync(string usuario, string contrasenia)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "http://panelparent.somee.com/api/usuariom/autenticarm";
                client.DefaultRequestHeaders.Add("Usuario", usuario);
                client.DefaultRequestHeaders.Add("Contrasenia", contrasenia);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    string result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        // Ajusta según el formato real de la respuesta
                        return new ValidacionResultado { EsValido = true, Token = result };
                    }
                    else
                    {
                        return new ValidacionResultado { EsValido = false, MensajeError = result };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con la API: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new ValidacionResultado { EsValido = false, MensajeError = ex.Message };
                }
            }
        }


        #region Otros
        // Método para manejar el evento KeyDown de txtUsuario
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContraseña.Focus();
                e.SuppressKeyPress = true; // Para evitar que el "ding" suene
            }
        }

        // Método para manejar el evento KeyDown de txtContraseña
        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciar_Click(sender, e);
                e.SuppressKeyPress = true; // Para evitar que el "ding" suene
            }
        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtContraseña.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtContraseña.PasswordChar = '*';
        }
        #endregion
    }
}
