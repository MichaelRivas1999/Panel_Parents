using Capa_de_Negocio.Maestro;
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
    public partial class AgregarMaestro : Form
    {
        // Instancia de `RegistrarMaestro` para interactuar con la API
        //private readonly RegistrarMaestro _maestroService = new RegistrarMaestro();

        //public AgregarMaestro()
        //{
        //    InitializeComponent();
        //}


        //private void AgregarMaestro_Load_1(object sender, EventArgs e)
        //{
           
        //    lblDocente.BackColor = Color.Transparent;
        //    lblDocente.ForeColor = Color.White;
            
        //    lblNombres.BackColor = Color.Transparent;
        //    lblNombres.ForeColor = Color.White;
            
        //    lblApellidos.BackColor = Color.Transparent;
        //    lblApellidos.ForeColor = Color.White;

        //    lblFechaNacimiento.BackColor = Color.Transparent;
        //    lblFechaNacimiento.ForeColor = Color.White;

        //    lblDireccion.BackColor = Color.Transparent;
        //    lblDireccion.ForeColor = Color.White;

        //    lblCorreo.BackColor = Color.Transparent;
        //    lblCorreo.ForeColor = Color.White;

        //    lblCelular.BackColor = Color.Transparent;
        //    lblCelular.ForeColor = Color.White;

        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private async void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    // Crear una instancia de `Maestro` con los datos del formulario
        //    var maestro = new Maestro
        //    {
        //        Nombre = Txt_M_Nombre.Text,          // Nombre del maestro
        //        Usuario = Txt_M_Apellidos.Text,        // Usuario del maestro
        //              // Contraseña del maestro
        //    };

        //    // Llamar al método para registrar el nuevo maestro en la API
        //    bool resultado = await _maestroService.RegistrarMaestroAsync(maestro);

        //    // Mostrar un mensaje de éxito o error basado en el resultado de la operación
        //    if (resultado)
        //    {
        //        MessageBox.Show("Maestro registrado con éxito.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Hubo un error al registrar el maestro.");
        //    }
        //}

        //private void btnBorrar_Click(object sender, EventArgs e)
        //{
        //    // Limpiar los campos del formulario
        //    Txt_M_Nombre.Clear();
        //    Txt_M_Apellidos.Clear();
            

        //}

        //private void Txt_M_Nombre_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
