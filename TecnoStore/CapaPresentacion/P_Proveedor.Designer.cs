namespace CapaPresentacion
{
    partial class P_Proveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNombreContacto = new System.Windows.Forms.TextBox();
            this.LblErrorNombreContacto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDireccionWeb = new System.Windows.Forms.TextBox();
            this.MtbTelefonoContacto = new System.Windows.Forms.MaskedTextBox();
            this.LblErrorDireccionWeb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblErrorTelefonoContacto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombreProveedor = new System.Windows.Forms.TextBox();
            this.LblErrorNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TxtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.LspBuscar = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAgregarProveedor = new System.Windows.Forms.Button();
            this.BtnEditarProveedor = new System.Windows.Forms.Button();
            this.BtnGuardarProveedor = new System.Windows.Forms.Button();
            this.BtnCancelarGuardado = new System.Windows.Forms.Button();
            this.BtnBorrarProveedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DtvProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNombreContacto);
            this.groupBox1.Controls.Add(this.LblErrorNombreContacto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtDireccionWeb);
            this.groupBox1.Controls.Add(this.MtbTelefonoContacto);
            this.groupBox1.Controls.Add(this.LblErrorDireccionWeb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblErrorTelefonoContacto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombreProveedor);
            this.groupBox1.Controls.Add(this.LblErrorNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.shapeContainer2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 415);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PROVEEDOR";
            // 
            // TxtNombreContacto
            // 
            this.TxtNombreContacto.BackColor = System.Drawing.Color.Black;
            this.TxtNombreContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreContacto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreContacto.ForeColor = System.Drawing.Color.White;
            this.TxtNombreContacto.Location = new System.Drawing.Point(242, 130);
            this.TxtNombreContacto.Multiline = true;
            this.TxtNombreContacto.Name = "TxtNombreContacto";
            this.TxtNombreContacto.Size = new System.Drawing.Size(422, 32);
            this.TxtNombreContacto.TabIndex = 63;
            this.TxtNombreContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNombreContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreContacto_KeyPress);
            // 
            // LblErrorNombreContacto
            // 
            this.LblErrorNombreContacto.AutoSize = true;
            this.LblErrorNombreContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblErrorNombreContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorNombreContacto.ForeColor = System.Drawing.Color.Yellow;
            this.LblErrorNombreContacto.Location = new System.Drawing.Point(10, 170);
            this.LblErrorNombreContacto.Name = "LblErrorNombreContacto";
            this.LblErrorNombreContacto.Size = new System.Drawing.Size(242, 17);
            this.LblErrorNombreContacto.TabIndex = 70;
            this.LblErrorNombreContacto.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
            this.LblErrorNombreContacto.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "NOMBRE DE CONTACTO";
            // 
            // TxtDireccionWeb
            // 
            this.TxtDireccionWeb.BackColor = System.Drawing.Color.Black;
            this.TxtDireccionWeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDireccionWeb.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccionWeb.ForeColor = System.Drawing.Color.White;
            this.TxtDireccionWeb.Location = new System.Drawing.Point(170, 290);
            this.TxtDireccionWeb.Multiline = true;
            this.TxtDireccionWeb.Name = "TxtDireccionWeb";
            this.TxtDireccionWeb.Size = new System.Drawing.Size(476, 32);
            this.TxtDireccionWeb.TabIndex = 65;
            this.TxtDireccionWeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MtbTelefonoContacto
            // 
            this.MtbTelefonoContacto.BackColor = System.Drawing.Color.Black;
            this.MtbTelefonoContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MtbTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTelefonoContacto.ForeColor = System.Drawing.Color.White;
            this.MtbTelefonoContacto.HidePromptOnLeave = true;
            this.MtbTelefonoContacto.Location = new System.Drawing.Point(256, 208);
            this.MtbTelefonoContacto.Mask = "(000) 000 - 0000";
            this.MtbTelefonoContacto.Name = "MtbTelefonoContacto";
            this.MtbTelefonoContacto.Size = new System.Drawing.Size(300, 34);
            this.MtbTelefonoContacto.TabIndex = 64;
            this.MtbTelefonoContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MtbTelefonoContacto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MtbTelefonoContacto_MouseClick);
            this.MtbTelefonoContacto.Enter += new System.EventHandler(this.MtbTelefonoContacto_Enter);
            this.MtbTelefonoContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtbTelefonoContacto_KeyPress);
            // 
            // LblErrorDireccionWeb
            // 
            this.LblErrorDireccionWeb.AutoSize = true;
            this.LblErrorDireccionWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblErrorDireccionWeb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorDireccionWeb.ForeColor = System.Drawing.Color.Yellow;
            this.LblErrorDireccionWeb.Location = new System.Drawing.Point(10, 330);
            this.LblErrorDireccionWeb.Name = "LblErrorDireccionWeb";
            this.LblErrorDireccionWeb.Size = new System.Drawing.Size(242, 17);
            this.LblErrorDireccionWeb.TabIndex = 66;
            this.LblErrorDireccionWeb.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
            this.LblErrorDireccionWeb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 23);
            this.label4.TabIndex = 65;
            this.label4.Text = "DIRECCION WEB";
            // 
            // LblErrorTelefonoContacto
            // 
            this.LblErrorTelefonoContacto.AutoSize = true;
            this.LblErrorTelefonoContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblErrorTelefonoContacto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorTelefonoContacto.ForeColor = System.Drawing.Color.Yellow;
            this.LblErrorTelefonoContacto.Location = new System.Drawing.Point(10, 250);
            this.LblErrorTelefonoContacto.Name = "LblErrorTelefonoContacto";
            this.LblErrorTelefonoContacto.Size = new System.Drawing.Size(242, 17);
            this.LblErrorTelefonoContacto.TabIndex = 64;
            this.LblErrorTelefonoContacto.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
            this.LblErrorTelefonoContacto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "TELEFONO DE CONTACTO";
            // 
            // TxtNombreProveedor
            // 
            this.TxtNombreProveedor.BackColor = System.Drawing.Color.Black;
            this.TxtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNombreProveedor.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreProveedor.ForeColor = System.Drawing.Color.White;
            this.TxtNombreProveedor.Location = new System.Drawing.Point(225, 45);
            this.TxtNombreProveedor.Multiline = true;
            this.TxtNombreProveedor.Name = "TxtNombreProveedor";
            this.TxtNombreProveedor.Size = new System.Drawing.Size(300, 32);
            this.TxtNombreProveedor.TabIndex = 62;
            this.TxtNombreProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNombreProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreProveedor_KeyPress);
            // 
            // LblErrorNombre
            // 
            this.LblErrorNombre.AutoSize = true;
            this.LblErrorNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblErrorNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorNombre.ForeColor = System.Drawing.Color.Yellow;
            this.LblErrorNombre.Location = new System.Drawing.Point(10, 85);
            this.LblErrorNombre.Name = "LblErrorNombre";
            this.LblErrorNombre.Size = new System.Drawing.Size(242, 17);
            this.LblErrorNombre.TabIndex = 60;
            this.LblErrorNombre.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
            this.LblErrorNombre.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "NOMBRE PROVEEDOR";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 44);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1,
            this.lineShape7});
            this.shapeContainer2.Size = new System.Drawing.Size(664, 368);
            this.shapeContainer2.TabIndex = 61;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape3.BorderWidth = 3;
            this.lineShape3.Enabled = false;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 163;
            this.lineShape3.X2 = 660;
            this.lineShape3.Y1 = 281;
            this.lineShape3.Y2 = 281;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 250;
            this.lineShape2.X2 = 555;
            this.lineShape2.Y1 = 201;
            this.lineShape2.Y2 = 201;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 239;
            this.lineShape1.X2 = 660;
            this.lineShape1.Y1 = 121;
            this.lineShape1.Y2 = 121;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape7.BorderWidth = 3;
            this.lineShape7.Enabled = false;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 218;
            this.lineShape7.X2 = 523;
            this.lineShape7.Y1 = 36;
            this.lineShape7.Y2 = 36;
            // 
            // TxtBuscarProveedor
            // 
            this.TxtBuscarProveedor.BackColor = System.Drawing.Color.Black;
            this.TxtBuscarProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscarProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.TxtBuscarProveedor.Location = new System.Drawing.Point(105, 60);
            this.TxtBuscarProveedor.Multiline = true;
            this.TxtBuscarProveedor.Name = "TxtBuscarProveedor";
            this.TxtBuscarProveedor.Size = new System.Drawing.Size(290, 25);
            this.TxtBuscarProveedor.TabIndex = 32;
            this.TxtBuscarProveedor.TabStop = false;
            this.TxtBuscarProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscarProveedor.TextChanged += new System.EventHandler(this.TxtBuscarProveedor_TextChanged);
            this.TxtBuscarProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarProveedor_KeyPress);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.ForeColor = System.Drawing.Color.White;
            this.LblBuscar.Location = new System.Drawing.Point(10, 62);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(90, 25);
            this.LblBuscar.TabIndex = 31;
            this.LblBuscar.Text = "BUSCAR";
            this.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LspBuscar
            // 
            this.LspBuscar.BorderColor = System.Drawing.Color.DimGray;
            this.LspBuscar.BorderWidth = 3;
            this.LspBuscar.Enabled = false;
            this.LspBuscar.Name = "LspBuscar";
            this.LspBuscar.X1 = 100;
            this.LspBuscar.X2 = 400;
            this.LspBuscar.Y1 = 88;
            this.LspBuscar.Y2 = 88;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LspBuscar});
            this.shapeContainer1.Size = new System.Drawing.Size(1200, 575);
            this.shapeContainer1.TabIndex = 33;
            this.shapeContainer1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources._547112644_157;
            this.pictureBox1.Location = new System.Drawing.Point(688, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAgregarProveedor
            // 
            this.BtnAgregarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregarProveedor.BackColor = System.Drawing.Color.Lime;
            this.BtnAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProveedor.Image = global::CapaPresentacion.Properties.Resources.agregar_al_portapapeles_simbolo_de_interfaz_negro;
            this.BtnAgregarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarProveedor.Location = new System.Drawing.Point(420, 530);
            this.BtnAgregarProveedor.Name = "BtnAgregarProveedor";
            this.BtnAgregarProveedor.Size = new System.Drawing.Size(150, 35);
            this.BtnAgregarProveedor.TabIndex = 41;
            this.BtnAgregarProveedor.TabStop = false;
            this.BtnAgregarProveedor.Text = "AGREGAR";
            this.BtnAgregarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarProveedor.UseVisualStyleBackColor = false;
            this.BtnAgregarProveedor.Click += new System.EventHandler(this.BtnAgregarProveedor_Click);
            // 
            // BtnEditarProveedor
            // 
            this.BtnEditarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEditarProveedor.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnEditarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarProveedor.Image = global::CapaPresentacion.Properties.Resources.editar;
            this.BtnEditarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarProveedor.Location = new System.Drawing.Point(10, 530);
            this.BtnEditarProveedor.Name = "BtnEditarProveedor";
            this.BtnEditarProveedor.Size = new System.Drawing.Size(125, 35);
            this.BtnEditarProveedor.TabIndex = 38;
            this.BtnEditarProveedor.TabStop = false;
            this.BtnEditarProveedor.Text = "EDITAR";
            this.BtnEditarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditarProveedor.UseVisualStyleBackColor = false;
            this.BtnEditarProveedor.Click += new System.EventHandler(this.BtnEditarProveedor_Click);
            // 
            // BtnGuardarProveedor
            // 
            this.BtnGuardarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarProveedor.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnGuardarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarProveedor.Image = global::CapaPresentacion.Properties.Resources.guardar;
            this.BtnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarProveedor.Location = new System.Drawing.Point(900, 531);
            this.BtnGuardarProveedor.Name = "BtnGuardarProveedor";
            this.BtnGuardarProveedor.Size = new System.Drawing.Size(150, 35);
            this.BtnGuardarProveedor.TabIndex = 43;
            this.BtnGuardarProveedor.TabStop = false;
            this.BtnGuardarProveedor.Text = "GUARDAR";
            this.BtnGuardarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarProveedor.UseVisualStyleBackColor = false;
            this.BtnGuardarProveedor.Visible = false;
            this.BtnGuardarProveedor.Click += new System.EventHandler(this.BtnGuardarProveedor_Click);
            // 
            // BtnCancelarGuardado
            // 
            this.BtnCancelarGuardado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelarGuardado.BackColor = System.Drawing.Color.Orange;
            this.BtnCancelarGuardado.FlatAppearance.BorderSize = 0;
            this.BtnCancelarGuardado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCancelarGuardado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCancelarGuardado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarGuardado.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarGuardado.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.BtnCancelarGuardado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarGuardado.Location = new System.Drawing.Point(688, 531);
            this.BtnCancelarGuardado.Name = "BtnCancelarGuardado";
            this.BtnCancelarGuardado.Size = new System.Drawing.Size(160, 35);
            this.BtnCancelarGuardado.TabIndex = 42;
            this.BtnCancelarGuardado.TabStop = false;
            this.BtnCancelarGuardado.Text = "CANCELAR";
            this.BtnCancelarGuardado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarGuardado.UseVisualStyleBackColor = false;
            this.BtnCancelarGuardado.Visible = false;
            this.BtnCancelarGuardado.Click += new System.EventHandler(this.BtnCancelarGuardado_Click);
            // 
            // BtnBorrarProveedor
            // 
            this.BtnBorrarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBorrarProveedor.BackColor = System.Drawing.Color.Red;
            this.BtnBorrarProveedor.FlatAppearance.BorderSize = 0;
            this.BtnBorrarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnBorrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarProveedor.Image = global::CapaPresentacion.Properties.Resources.cubo_de_la_basura;
            this.BtnBorrarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrarProveedor.Location = new System.Drawing.Point(210, 530);
            this.BtnBorrarProveedor.Name = "BtnBorrarProveedor";
            this.BtnBorrarProveedor.Size = new System.Drawing.Size(135, 35);
            this.BtnBorrarProveedor.TabIndex = 40;
            this.BtnBorrarProveedor.TabStop = false;
            this.BtnBorrarProveedor.Text = "BORRAR";
            this.BtnBorrarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrarProveedor.UseVisualStyleBackColor = false;
            this.BtnBorrarProveedor.Click += new System.EventHandler(this.BtnBorrarProveedor_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.label1.Size = new System.Drawing.Size(1200, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROVEEDORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DtvProveedor
            // 
            this.DtvProveedor.AllowUserToAddRows = false;
            this.DtvProveedor.AllowUserToDeleteRows = false;
            this.DtvProveedor.AllowUserToResizeColumns = false;
            this.DtvProveedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DtvProveedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtvProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtvProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtvProveedor.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DtvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtvProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtvProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtvProveedor.ColumnHeadersHeight = 25;
            this.DtvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DtvProveedor.EnableHeadersVisualStyles = false;
            this.DtvProveedor.GridColor = System.Drawing.Color.Black;
            this.DtvProveedor.Location = new System.Drawing.Point(10, 98);
            this.DtvProveedor.Name = "DtvProveedor";
            this.DtvProveedor.ReadOnly = true;
            this.DtvProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtvProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtvProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.DtvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtvProveedor.Size = new System.Drawing.Size(1180, 425);
            this.DtvProveedor.TabIndex = 45;
            this.DtvProveedor.TabStop = false;
            // 
            // P_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 575);
            this.Controls.Add(this.DtvProveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAgregarProveedor);
            this.Controls.Add(this.BtnEditarProveedor);
            this.Controls.Add(this.BtnGuardarProveedor);
            this.Controls.Add(this.BtnCancelarGuardado);
            this.Controls.Add(this.BtnBorrarProveedor);
            this.Controls.Add(this.TxtBuscarProveedor);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Proveedor";
            this.Opacity = 0.95D;
            this.Text = "P_Proveedor";
            this.Load += new System.EventHandler(this.P_Proveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtBuscarProveedor;
        private System.Windows.Forms.Label LblBuscar;
        private Microsoft.VisualBasic.PowerPacks.LineShape LspBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button BtnAgregarProveedor;
        private System.Windows.Forms.Button BtnEditarProveedor;
        private System.Windows.Forms.Button BtnGuardarProveedor;
        private System.Windows.Forms.Button BtnCancelarGuardado;
        private System.Windows.Forms.Button BtnBorrarProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblErrorNombre;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.TextBox TxtNombreProveedor;
        private System.Windows.Forms.Label LblErrorTelefonoContacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblErrorDireccionWeb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MtbTelefonoContacto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox TxtDireccionWeb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombreContacto;
        private System.Windows.Forms.Label LblErrorNombreContacto;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.DataGridView DtvProveedor;
    }
}