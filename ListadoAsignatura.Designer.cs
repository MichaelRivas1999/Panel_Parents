
namespace Panel_Parents
{
    partial class ListadoAsignatura
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
            this.Dg_Asignatura = new System.Windows.Forms.DataGridView();
            this.comboBoxAsignatura = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblListado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Asignatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dg_Asignatura
            // 
            this.Dg_Asignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Asignatura.Location = new System.Drawing.Point(131, 158);
            this.Dg_Asignatura.Name = "Dg_Asignatura";
            this.Dg_Asignatura.Size = new System.Drawing.Size(784, 331);
            this.Dg_Asignatura.TabIndex = 72;
            // 
            // comboBoxAsignatura
            // 
            this.comboBoxAsignatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAsignatura.FormattingEnabled = true;
            this.comboBoxAsignatura.IntegralHeight = false;
            this.comboBoxAsignatura.ItemHeight = 20;
            this.comboBoxAsignatura.Location = new System.Drawing.Point(209, 100);
            this.comboBoxAsignatura.Name = "comboBoxAsignatura";
            this.comboBoxAsignatura.Size = new System.Drawing.Size(440, 28);
            this.comboBoxAsignatura.TabIndex = 71;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(126, 100);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(77, 30);
            this.lblBuscar.TabIndex = 70;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.BackColor = System.Drawing.Color.Transparent;
            this.lblListado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.ForeColor = System.Drawing.Color.Black;
            this.lblListado.Location = new System.Drawing.Point(122, 29);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(346, 45);
            this.lblListado.TabIndex = 69;
            this.lblListado.Text = "Listado de Asignatura";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Panel_Parents.Properties.Resources.Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 684);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // ListadoAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 684);
            this.Controls.Add(this.Dg_Asignatura);
            this.Controls.Add(this.comboBoxAsignatura);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListadoAsignatura";
            this.Text = "ListadoAsignatura";
            this.Load += new System.EventHandler(this.ListadoAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Asignatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dg_Asignatura;
        private System.Windows.Forms.ComboBox comboBoxAsignatura;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}