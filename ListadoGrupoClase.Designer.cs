
namespace Panel_Parents
{
    partial class ListadoGrupoClase
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
            this.Dg_GrupoClase = new System.Windows.Forms.DataGridView();
            this.comboBoxGrupoClase = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_GrupoClase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_GrupoClase
            // 
            this.Dg_GrupoClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_GrupoClase.Location = new System.Drawing.Point(141, 160);
            this.Dg_GrupoClase.Name = "Dg_GrupoClase";
            this.Dg_GrupoClase.Size = new System.Drawing.Size(784, 331);
            this.Dg_GrupoClase.TabIndex = 67;
            // 
            // comboBoxGrupoClase
            // 
            this.comboBoxGrupoClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrupoClase.FormattingEnabled = true;
            this.comboBoxGrupoClase.IntegralHeight = false;
            this.comboBoxGrupoClase.ItemHeight = 20;
            this.comboBoxGrupoClase.Location = new System.Drawing.Point(219, 102);
            this.comboBoxGrupoClase.Name = "comboBoxGrupoClase";
            this.comboBoxGrupoClase.Size = new System.Drawing.Size(440, 28);
            this.comboBoxGrupoClase.TabIndex = 66;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(136, 102);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 30);
            this.lblBuscar.TabIndex = 65;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.Transparent;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.Black;
            this.lblListado.Location = new System.Drawing.Point(132, 31);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(424, 45);
            this.lblListado.TabIndex = 64;
            this.lblListado.Text = "Listado de Grupo de Clases";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Panel_Parents.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoGrupoClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 684);
            this.Controls.Add(this.Dg_GrupoClase);
            this.Controls.Add(this.comboBoxGrupoClase);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListadoGrupoClase";
            this.Text = "ListadoGrupoClase";
            this.Load += new System.EventHandler(this.ListadoGrupoClase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_GrupoClase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_GrupoClase;
        private System.Windows.Forms.ComboBox comboBoxGrupoClase;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}