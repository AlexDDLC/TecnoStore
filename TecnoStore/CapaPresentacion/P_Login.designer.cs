namespace CapaPresentacion
{
    partial class P_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtcontrasena = new System.Windows.Forms.TextBox();
            this.Btnacceder = new System.Windows.Forms.Button();
            this.LblLoguin = new System.Windows.Forms.Label();
            this.Lblerrorusuario = new System.Windows.Forms.Label();
            this.Lblerrorcontrasena = new System.Windows.Forms.Label();
            this.Lblerrorlogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnocultarContrasena = new System.Windows.Forms.Button();
            this.BtnMostrarContrasena = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btncerrar = new System.Windows.Forms.Button();
            this.Btnminimizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(500, 550);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 25;
            this.lineShape2.X2 = 475;
            this.lineShape2.Y1 = 368;
            this.lineShape2.Y2 = 368;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 25;
            this.lineShape1.X2 = 475;
            this.lineShape1.Y1 = 262;
            this.lineShape1.Y2 = 262;
            // 
            // Txtusuario
            // 
            this.Txtusuario.BackColor = System.Drawing.Color.Black;
            this.Txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtusuario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtusuario.ForeColor = System.Drawing.Color.White;
            this.Txtusuario.Location = new System.Drawing.Point(25, 224);
            this.Txtusuario.Multiline = true;
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(451, 35);
            this.Txtusuario.TabIndex = 2;
            this.Txtusuario.Text = "USUARIO";
            this.Txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtusuario.Enter += new System.EventHandler(this.Txtusuario_Enter);
            this.Txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtusuario_KeyPress);
            this.Txtusuario.Leave += new System.EventHandler(this.Txtusuario_Leave);
            // 
            // Txtcontrasena
            // 
            this.Txtcontrasena.BackColor = System.Drawing.Color.Black;
            this.Txtcontrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtcontrasena.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcontrasena.ForeColor = System.Drawing.Color.White;
            this.Txtcontrasena.Location = new System.Drawing.Point(25, 330);
            this.Txtcontrasena.Multiline = true;
            this.Txtcontrasena.Name = "Txtcontrasena";
            this.Txtcontrasena.Size = new System.Drawing.Size(451, 35);
            this.Txtcontrasena.TabIndex = 3;
            this.Txtcontrasena.Text = "CONTRASEÑA";
            this.Txtcontrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txtcontrasena.Enter += new System.EventHandler(this.Txtcontrasena_Enter);
            this.Txtcontrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcontrasena_KeyPress);
            this.Txtcontrasena.Leave += new System.EventHandler(this.Txtcontrasena_Leave);
            // 
            // Btnacceder
            // 
            this.Btnacceder.BackColor = System.Drawing.Color.DimGray;
            this.Btnacceder.FlatAppearance.BorderSize = 0;
            this.Btnacceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btnacceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnacceder.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnacceder.Location = new System.Drawing.Point(25, 447);
            this.Btnacceder.Name = "Btnacceder";
            this.Btnacceder.Size = new System.Drawing.Size(450, 45);
            this.Btnacceder.TabIndex = 4;
            this.Btnacceder.Text = "ACCEDER";
            this.Btnacceder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btnacceder.UseVisualStyleBackColor = false;
            this.Btnacceder.Click += new System.EventHandler(this.Btnacceder_Click);
            // 
            // LblLoguin
            // 
            this.LblLoguin.BackColor = System.Drawing.Color.White;
            this.LblLoguin.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblLoguin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblLoguin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoguin.ForeColor = System.Drawing.Color.Black;
            this.LblLoguin.Location = new System.Drawing.Point(0, 0);
            this.LblLoguin.Name = "LblLoguin";
            this.LblLoguin.Size = new System.Drawing.Size(500, 35);
            this.LblLoguin.TabIndex = 0;
            this.LblLoguin.Text = "LOGIN";
            this.LblLoguin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblLoguin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // Lblerrorusuario
            // 
            this.Lblerrorusuario.AutoSize = true;
            this.Lblerrorusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblerrorusuario.ForeColor = System.Drawing.Color.Yellow;
            this.Lblerrorusuario.Location = new System.Drawing.Point(22, 265);
            this.Lblerrorusuario.Name = "Lblerrorusuario";
            this.Lblerrorusuario.Size = new System.Drawing.Size(107, 17);
            this.Lblerrorusuario.TabIndex = 0;
            this.Lblerrorusuario.Text = "Error de usuario";
            this.Lblerrorusuario.Visible = false;
            // 
            // Lblerrorcontrasena
            // 
            this.Lblerrorcontrasena.AutoSize = true;
            this.Lblerrorcontrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblerrorcontrasena.ForeColor = System.Drawing.Color.Yellow;
            this.Lblerrorcontrasena.Location = new System.Drawing.Point(22, 373);
            this.Lblerrorcontrasena.Name = "Lblerrorcontrasena";
            this.Lblerrorcontrasena.Size = new System.Drawing.Size(113, 17);
            this.Lblerrorcontrasena.TabIndex = 0;
            this.Lblerrorcontrasena.Text = "Error contrasena";
            this.Lblerrorcontrasena.Visible = false;
            // 
            // Lblerrorlogin
            // 
            this.Lblerrorlogin.AutoSize = true;
            this.Lblerrorlogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblerrorlogin.ForeColor = System.Drawing.Color.Red;
            this.Lblerrorlogin.Location = new System.Drawing.Point(22, 427);
            this.Lblerrorlogin.Name = "Lblerrorlogin";
            this.Lblerrorlogin.Size = new System.Drawing.Size(72, 17);
            this.Lblerrorlogin.TabIndex = 0;
            this.Lblerrorlogin.Text = "Error login";
            this.Lblerrorlogin.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // BtnocultarContrasena
            // 
            this.BtnocultarContrasena.BackColor = System.Drawing.Color.DimGray;
            this.BtnocultarContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnocultarContrasena.FlatAppearance.BorderSize = 0;
            this.BtnocultarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnocultarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnocultarContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnocultarContrasena.Image = global::CapaPresentacion.Properties.Resources.ciego;
            this.BtnocultarContrasena.Location = new System.Drawing.Point(441, 330);
            this.BtnocultarContrasena.Name = "BtnocultarContrasena";
            this.BtnocultarContrasena.Size = new System.Drawing.Size(35, 35);
            this.BtnocultarContrasena.TabIndex = 9;
            this.BtnocultarContrasena.UseVisualStyleBackColor = false;
            this.BtnocultarContrasena.Visible = false;
            this.BtnocultarContrasena.Click += new System.EventHandler(this.BtnocultarContrasena_Click);
            // 
            // BtnMostrarContrasena
            // 
            this.BtnMostrarContrasena.BackColor = System.Drawing.Color.DimGray;
            this.BtnMostrarContrasena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMostrarContrasena.FlatAppearance.BorderSize = 0;
            this.BtnMostrarContrasena.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMostrarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnMostrarContrasena.Image = global::CapaPresentacion.Properties.Resources.ojo;
            this.BtnMostrarContrasena.Location = new System.Drawing.Point(441, 330);
            this.BtnMostrarContrasena.Name = "BtnMostrarContrasena";
            this.BtnMostrarContrasena.Size = new System.Drawing.Size(35, 35);
            this.BtnMostrarContrasena.TabIndex = 8;
            this.BtnMostrarContrasena.UseVisualStyleBackColor = false;
            this.BtnMostrarContrasena.Visible = false;
            this.BtnMostrarContrasena.Click += new System.EventHandler(this.BtnMostrarContrasena_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(173, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Btncerrar
            // 
            this.Btncerrar.BackColor = System.Drawing.Color.White;
            this.Btncerrar.FlatAppearance.BorderSize = 0;
            this.Btncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btncerrar.Image = global::CapaPresentacion.Properties.Resources.boton_cerrar;
            this.Btncerrar.Location = new System.Drawing.Point(465, 0);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(35, 35);
            this.Btncerrar.TabIndex = 5;
            this.Btncerrar.TabStop = false;
            this.Btncerrar.UseVisualStyleBackColor = false;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // Btnminimizar
            // 
            this.Btnminimizar.BackColor = System.Drawing.Color.White;
            this.Btnminimizar.FlatAppearance.BorderSize = 0;
            this.Btnminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnminimizar.Image = global::CapaPresentacion.Properties.Resources.restar;
            this.Btnminimizar.Location = new System.Drawing.Point(430, 0);
            this.Btnminimizar.Name = "Btnminimizar";
            this.Btnminimizar.Size = new System.Drawing.Size(35, 35);
            this.Btnminimizar.TabIndex = 4;
            this.Btnminimizar.TabStop = false;
            this.Btnminimizar.UseVisualStyleBackColor = false;
            this.Btnminimizar.Click += new System.EventHandler(this.Btnminimizar_Click);
            // 
            // P_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.BtnMostrarContrasena);
            this.Controls.Add(this.BtnocultarContrasena);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lblerrorlogin);
            this.Controls.Add(this.Lblerrorcontrasena);
            this.Controls.Add(this.Lblerrorusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btncerrar);
            this.Controls.Add(this.Btnminimizar);
            this.Controls.Add(this.LblLoguin);
            this.Controls.Add(this.Btnacceder);
            this.Controls.Add(this.Txtcontrasena);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox Txtcontrasena;
        private System.Windows.Forms.Button Btnacceder;
        private System.Windows.Forms.Label LblLoguin;
        private System.Windows.Forms.Button Btnminimizar;
        private System.Windows.Forms.Button Btncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lblerrorusuario;
        private System.Windows.Forms.Label Lblerrorcontrasena;
        private System.Windows.Forms.Label Lblerrorlogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnMostrarContrasena;
        private System.Windows.Forms.Button BtnocultarContrasena;
    }
}

