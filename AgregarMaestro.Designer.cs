
//namespace Panel_Parents
//{
//    partial class AgregarMaestro
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.lblDocente = new System.Windows.Forms.Label();
//            this.lblNombres = new System.Windows.Forms.Label();
//            this.lblApellidos = new System.Windows.Forms.Label();
//            this.Txt_M_Apellidos = new System.Windows.Forms.TextBox();
//            this.Txt_M_Nombre = new System.Windows.Forms.TextBox();
//            this.btn_Guardar = new System.Windows.Forms.Button();
//            this.btnBorrar = new System.Windows.Forms.Button();
//            this.lblFechaNacimiento = new System.Windows.Forms.Label();
//            this.textBox2 = new System.Windows.Forms.TextBox();
//            this.lblDireccion = new System.Windows.Forms.Label();
//            this.textBox3 = new System.Windows.Forms.TextBox();
//            this.lblCorreo = new System.Windows.Forms.Label();
//            this.textBox4 = new System.Windows.Forms.TextBox();
//            this.lblCelular = new System.Windows.Forms.Label();
//            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
//            this.SuspendLayout();
//            // 
//            // lblDocente
//            // 
//            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblDocente.AutoSize = true;
//            this.lblDocente.BackColor = System.Drawing.Color.Transparent;
//            this.lblDocente.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblDocente.ForeColor = System.Drawing.Color.Black;
//            this.lblDocente.Location = new System.Drawing.Point(145, 22);
//            this.lblDocente.Name = "lblDocente";
//            this.lblDocente.Size = new System.Drawing.Size(158, 45);
//            this.lblDocente.TabIndex = 4;
//            this.lblDocente.Text = "Docentes";
//            this.lblDocente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.lblDocente.UseWaitCursor = true;
//            // 
//            // lblNombres
//            // 
//            this.lblNombres.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblNombres.AutoSize = true;
//            this.lblNombres.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblNombres.ForeColor = System.Drawing.Color.Black;
//            this.lblNombres.Location = new System.Drawing.Point(140, 101);
//            this.lblNombres.Name = "lblNombres";
//            this.lblNombres.Size = new System.Drawing.Size(78, 21);
//            this.lblNombres.TabIndex = 5;
//            this.lblNombres.Text = "Nombres";
//            // 
//            // lblApellidos
//            // 
//            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblApellidos.AutoSize = true;
//            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblApellidos.ForeColor = System.Drawing.Color.Black;
//            this.lblApellidos.Location = new System.Drawing.Point(488, 101);
//            this.lblApellidos.Name = "lblApellidos";
//            this.lblApellidos.Size = new System.Drawing.Size(79, 21);
//            this.lblApellidos.TabIndex = 6;
//            this.lblApellidos.Text = "Apellidos";
//            // 
//            // Txt_M_Apellidos
//            // 
//            this.Txt_M_Apellidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.Txt_M_Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Txt_M_Apellidos.Location = new System.Drawing.Point(492, 126);
//            this.Txt_M_Apellidos.Margin = new System.Windows.Forms.Padding(4);
//            this.Txt_M_Apellidos.Name = "Txt_M_Apellidos";
//            this.Txt_M_Apellidos.Size = new System.Drawing.Size(303, 30);
//            this.Txt_M_Apellidos.TabIndex = 11;
//            this.Txt_M_Apellidos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
//            // 
//            // Txt_M_Nombre
//            // 
//            this.Txt_M_Nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.Txt_M_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.Txt_M_Nombre.Location = new System.Drawing.Point(144, 126);
//            this.Txt_M_Nombre.Margin = new System.Windows.Forms.Padding(4);
//            this.Txt_M_Nombre.Name = "Txt_M_Nombre";
//            this.Txt_M_Nombre.Size = new System.Drawing.Size(303, 30);
//            this.Txt_M_Nombre.TabIndex = 13;
//            this.Txt_M_Nombre.TextChanged += new System.EventHandler(this.Txt_M_Nombre_TextChanged);
//            // 
//            // btn_Guardar
//            // 
//            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.btn_Guardar.BackColor = System.Drawing.Color.Green;
//            this.btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
//            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
//            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
//            this.btn_Guardar.Location = new System.Drawing.Point(224, 437);
//            this.btn_Guardar.Name = "btn_Guardar";
//            this.btn_Guardar.Size = new System.Drawing.Size(126, 37);
//            this.btn_Guardar.TabIndex = 20;
//            this.btn_Guardar.Text = "Guardar";
//            this.btn_Guardar.UseVisualStyleBackColor = false;
//            this.btn_Guardar.Click += new System.EventHandler(this.btnGuardar_Click);
//            // 
//            // btnBorrar
//            // 
//            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
//            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
//            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
//            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnBorrar.ForeColor = System.Drawing.Color.White;
//            this.btnBorrar.Location = new System.Drawing.Point(429, 437);
//            this.btnBorrar.Name = "btnBorrar";
//            this.btnBorrar.Size = new System.Drawing.Size(126, 37);
//            this.btnBorrar.TabIndex = 21;
//            this.btnBorrar.Text = "Limpiar";
//            this.btnBorrar.UseVisualStyleBackColor = false;
//            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
//            // 
//            // lblFechaNacimiento
//            // 
//            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblFechaNacimiento.AutoSize = true;
//            this.lblFechaNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black;
//            this.lblFechaNacimiento.Location = new System.Drawing.Point(385, 199);
//            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
//            this.lblFechaNacimiento.Size = new System.Drawing.Size(163, 21);
//            this.lblFechaNacimiento.TabIndex = 7;
//            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
//            // 
//            // textBox2
//            // 
//            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.textBox2.Location = new System.Drawing.Point(144, 289);
//            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
//            this.textBox2.Name = "textBox2";
//            this.textBox2.Size = new System.Drawing.Size(651, 30);
//            this.textBox2.TabIndex = 25;
//            // 
//            // lblDireccion
//            // 
//            this.lblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblDireccion.AutoSize = true;
//            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
//            this.lblDireccion.Location = new System.Drawing.Point(140, 264);
//            this.lblDireccion.Name = "lblDireccion";
//            this.lblDireccion.Size = new System.Drawing.Size(79, 21);
//            this.lblDireccion.TabIndex = 24;
//            this.lblDireccion.Text = "Direccion";
//            // 
//            // textBox3
//            // 
//            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.textBox3.Location = new System.Drawing.Point(144, 366);
//            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
//            this.textBox3.Name = "textBox3";
//            this.textBox3.Size = new System.Drawing.Size(303, 30);
//            this.textBox3.TabIndex = 27;
//            // 
//            // lblCorreo
//            // 
//            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblCorreo.AutoSize = true;
//            this.lblCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
//            this.lblCorreo.Location = new System.Drawing.Point(140, 341);
//            this.lblCorreo.Name = "lblCorreo";
//            this.lblCorreo.Size = new System.Drawing.Size(61, 21);
//            this.lblCorreo.TabIndex = 26;
//            this.lblCorreo.Text = "Correo";
//            // 
//            // textBox4
//            // 
//            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.textBox4.Location = new System.Drawing.Point(492, 366);
//            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
//            this.textBox4.Name = "textBox4";
//            this.textBox4.Size = new System.Drawing.Size(303, 30);
//            this.textBox4.TabIndex = 29;
//            // 
//            // lblCelular
//            // 
//            this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.lblCelular.AutoSize = true;
//            this.lblCelular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblCelular.ForeColor = System.Drawing.Color.Black;
//            this.lblCelular.Location = new System.Drawing.Point(488, 341);
//            this.lblCelular.Name = "lblCelular";
//            this.lblCelular.Size = new System.Drawing.Size(60, 21);
//            this.lblCelular.TabIndex = 28;
//            this.lblCelular.Text = "Celular";
//            // 
//            // dtpFechaNacimiento
//            // 
//            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.dtpFechaNacimiento.Location = new System.Drawing.Point(309, 232);
//            this.dtpFechaNacimiento.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
//            this.dtpFechaNacimiento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
//            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
//            this.dtpFechaNacimiento.Size = new System.Drawing.Size(322, 20);
//            this.dtpFechaNacimiento.TabIndex = 30;
//            // 
//            // AgregarMaestro
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(817, 684);
//            this.Controls.Add(this.dtpFechaNacimiento);
//            this.Controls.Add(this.textBox4);
//            this.Controls.Add(this.lblCelular);
//            this.Controls.Add(this.textBox3);
//            this.Controls.Add(this.lblCorreo);
//            this.Controls.Add(this.textBox2);
//            this.Controls.Add(this.lblDireccion);
//            this.Controls.Add(this.btnBorrar);
//            this.Controls.Add(this.btn_Guardar);
//            this.Controls.Add(this.Txt_M_Nombre);
//            this.Controls.Add(this.Txt_M_Apellidos);
//            this.Controls.Add(this.lblFechaNacimiento);
//            this.Controls.Add(this.lblApellidos);
//            this.Controls.Add(this.lblNombres);
//            this.Controls.Add(this.lblDocente);
//            this.Name = "AgregarMaestro";
//            this.Text = "AgregarMaestro";
//            this.Load += new System.EventHandler(this.AgregarMaestro_Load_1);
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//        private System.Windows.Forms.Label lblDocente;
//        private System.Windows.Forms.Label lblNombres;
//        private System.Windows.Forms.Label lblApellidos;
//        private System.Windows.Forms.TextBox Txt_M_Apellidos;
//        private System.Windows.Forms.TextBox Txt_M_Nombre;
//        private System.Windows.Forms.Button btn_Guardar;
//        private System.Windows.Forms.Button btnBorrar;
//        private System.Windows.Forms.Label lblFechaNacimiento;
//        private System.Windows.Forms.TextBox textBox2;
//        private System.Windows.Forms.Label lblDireccion;
//        private System.Windows.Forms.TextBox textBox3;
//        private System.Windows.Forms.Label lblCorreo;
//        private System.Windows.Forms.TextBox textBox4;
//        private System.Windows.Forms.Label lblCelular;
//        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
//    }
//}
