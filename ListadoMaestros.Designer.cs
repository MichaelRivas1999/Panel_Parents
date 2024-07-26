
namespace Panel_Parents
{
    partial class ListadoMaestros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoMaestros));
            this.lblListado = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.comboBoxMaestros = new System.Windows.Forms.ComboBox();
            this.Dg_Maestro = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Maestro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.Transparent;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.Black;
            this.lblListado.Location = new System.Drawing.Point(133, 9);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(321, 45);
            this.lblListado.TabIndex = 59;
            this.lblListado.Text = "Listado de Docentes";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(137, 80);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 30);
            this.lblBuscar.TabIndex = 60;
            this.lblBuscar.Text = "Buscar";
            // 
            // comboBoxMaestros
            // 
            this.comboBoxMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaestros.FormattingEnabled = true;
            this.comboBoxMaestros.IntegralHeight = false;
            this.comboBoxMaestros.ItemHeight = 20;
            this.comboBoxMaestros.Location = new System.Drawing.Point(220, 80);
            this.comboBoxMaestros.MinimumSize = new System.Drawing.Size(350, 0);
            this.comboBoxMaestros.Name = "comboBoxMaestros";
            this.comboBoxMaestros.Size = new System.Drawing.Size(440, 28);
            this.comboBoxMaestros.TabIndex = 61;
            // 
            // Dg_Maestro
            // 
            this.Dg_Maestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Maestro.Location = new System.Drawing.Point(141, 146);
            this.Dg_Maestro.Name = "Dg_Maestro";
            this.Dg_Maestro.Size = new System.Drawing.Size(784, 331);
            this.Dg_Maestro.TabIndex = 62;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Panel_Parents.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 684);
            this.Controls.Add(this.Dg_Maestro);
            this.Controls.Add(this.comboBoxMaestros);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(833, 723);
            this.Name = "ListadoMaestros";
            this.Load += new System.EventHandler(this.ListadoMaestros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Maestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox comboBoxMaestros;
        private System.Windows.Forms.DataGridView Dg_Maestro;
    }
}