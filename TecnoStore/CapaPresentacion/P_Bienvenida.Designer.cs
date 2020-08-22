namespace CapaPresentacion
{
    partial class P_Bienvenida
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
            this.components = new System.ComponentModel.Container();
            this.LblErrorAcceso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNombreEmpleado = new System.Windows.Forms.Label();
            this.LblBienvenida = new System.Windows.Forms.Label();
            this.PgbProgreso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblProgreso = new System.Windows.Forms.Label();
            this.PtbTriangulo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblErrorAcceso
            // 
            this.LblErrorAcceso.AutoSize = true;
            this.LblErrorAcceso.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorAcceso.ForeColor = System.Drawing.Color.Yellow;
            this.LblErrorAcceso.Location = new System.Drawing.Point(8, 224);
            this.LblErrorAcceso.Name = "LblErrorAcceso";
            this.LblErrorAcceso.Size = new System.Drawing.Size(349, 27);
            this.LblErrorAcceso.TabIndex = 1;
            this.LblErrorAcceso.Text = "NO TIENE PERMISO DE ACCESO";
            this.LblErrorAcceso.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // LblNombreEmpleado
            // 
            this.LblNombreEmpleado.AutoSize = true;
            this.LblNombreEmpleado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreEmpleado.ForeColor = System.Drawing.Color.White;
            this.LblNombreEmpleado.Location = new System.Drawing.Point(44, 205);
            this.LblNombreEmpleado.Name = "LblNombreEmpleado";
            this.LblNombreEmpleado.Size = new System.Drawing.Size(258, 18);
            this.LblNombreEmpleado.TabIndex = 5;
            this.LblNombreEmpleado.Text = "Nelson Alexander Diaz De La Cruz";
            this.LblNombreEmpleado.Visible = false;
            // 
            // LblBienvenida
            // 
            this.LblBienvenida.AutoSize = true;
            this.LblBienvenida.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenida.ForeColor = System.Drawing.Color.White;
            this.LblBienvenida.Location = new System.Drawing.Point(105, 150);
            this.LblBienvenida.Name = "LblBienvenida";
            this.LblBienvenida.Size = new System.Drawing.Size(159, 32);
            this.LblBienvenida.TabIndex = 6;
            this.LblBienvenida.Text = "Bienvenido";
            this.LblBienvenida.Visible = false;
            // 
            // PgbProgreso
            // 
            this.PgbProgreso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PgbProgreso.Location = new System.Drawing.Point(0, 285);
            this.PgbProgreso.Name = "PgbProgreso";
            this.PgbProgreso.Size = new System.Drawing.Size(365, 10);
            this.PgbProgreso.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblProgreso
            // 
            this.LblProgreso.AutoSize = true;
            this.LblProgreso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgreso.ForeColor = System.Drawing.Color.White;
            this.LblProgreso.Location = new System.Drawing.Point(165, 260);
            this.LblProgreso.Name = "LblProgreso";
            this.LblProgreso.Size = new System.Drawing.Size(36, 19);
            this.LblProgreso.TabIndex = 8;
            this.LblProgreso.Text = "000";
            // 
            // PtbTriangulo
            // 
            this.PtbTriangulo.Image = global::CapaPresentacion.Properties.Resources.peligro;
            this.PtbTriangulo.Location = new System.Drawing.Point(160, 185);
            this.PtbTriangulo.Name = "PtbTriangulo";
            this.PtbTriangulo.Size = new System.Drawing.Size(32, 32);
            this.PtbTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PtbTriangulo.TabIndex = 2;
            this.PtbTriangulo.TabStop = false;
            this.PtbTriangulo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.UnlimitSoft;
            this.pictureBox1.Location = new System.Drawing.Point(80, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // P_Bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(365, 295);
            this.Controls.Add(this.LblProgreso);
            this.Controls.Add(this.PgbProgreso);
            this.Controls.Add(this.LblBienvenida);
            this.Controls.Add(this.LblNombreEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PtbTriangulo);
            this.Controls.Add(this.LblErrorAcceso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Bienvenida";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "P_Bienvenida";
            this.Load += new System.EventHandler(this.P_Bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblErrorAcceso;
        private System.Windows.Forms.PictureBox PtbTriangulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNombreEmpleado;
        private System.Windows.Forms.Label LblBienvenida;
        private System.Windows.Forms.ProgressBar PgbProgreso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblProgreso;
    }
}