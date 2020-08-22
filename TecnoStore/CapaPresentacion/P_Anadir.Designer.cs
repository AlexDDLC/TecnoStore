namespace CapaPresentacion
{
    partial class P_Anadir
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.DtvAnadir = new System.Windows.Forms.DataGridView();
            this.BtnCargo = new System.Windows.Forms.Button();
            this.BtnCategoria = new System.Windows.Forms.Button();
            this.BtnMarca = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblAnadir = new System.Windows.Forms.Label();
            this.TxtAnadir = new System.Windows.Forms.TextBox();
            this.LspBuscar = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.LblErrorElemento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtvAnadir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.label1.Size = new System.Drawing.Size(1200, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "AÑADIR ELEMENTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DtvAnadir
            // 
            this.DtvAnadir.AllowUserToAddRows = false;
            this.DtvAnadir.AllowUserToDeleteRows = false;
            this.DtvAnadir.AllowUserToResizeColumns = false;
            this.DtvAnadir.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DtvAnadir.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtvAnadir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtvAnadir.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtvAnadir.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DtvAnadir.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DtvAnadir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtvAnadir.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtvAnadir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtvAnadir.ColumnHeadersHeight = 25;
            this.DtvAnadir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtvAnadir.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtvAnadir.EnableHeadersVisualStyles = false;
            this.DtvAnadir.GridColor = System.Drawing.Color.Black;
            this.DtvAnadir.Location = new System.Drawing.Point(309, 75);
            this.DtvAnadir.Name = "DtvAnadir";
            this.DtvAnadir.ReadOnly = true;
            this.DtvAnadir.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtvAnadir.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DtvAnadir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DtvAnadir.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DtvAnadir.Size = new System.Drawing.Size(388, 425);
            this.DtvAnadir.TabIndex = 45;
            this.DtvAnadir.TabStop = false;
            // 
            // BtnCargo
            // 
            this.BtnCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCargo.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCargo.FlatAppearance.BorderSize = 0;
            this.BtnCargo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCargo.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargo.Image = global::CapaPresentacion.Properties.Resources.estructura_jerarquica;
            this.BtnCargo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCargo.Location = new System.Drawing.Point(745, 243);
            this.BtnCargo.Name = "BtnCargo";
            this.BtnCargo.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnCargo.Size = new System.Drawing.Size(150, 35);
            this.BtnCargo.TabIndex = 48;
            this.BtnCargo.TabStop = false;
            this.BtnCargo.Text = "CARGO";
            this.BtnCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCargo.UseVisualStyleBackColor = false;
            this.BtnCargo.Click += new System.EventHandler(this.BtnCargo_Click);
            // 
            // BtnCategoria
            // 
            this.BtnCategoria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCategoria.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCategoria.FlatAppearance.BorderSize = 0;
            this.BtnCategoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategoria.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategoria.Image = global::CapaPresentacion.Properties.Resources.categoria;
            this.BtnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategoria.Location = new System.Drawing.Point(745, 183);
            this.BtnCategoria.Name = "BtnCategoria";
            this.BtnCategoria.Size = new System.Drawing.Size(175, 35);
            this.BtnCategoria.TabIndex = 47;
            this.BtnCategoria.TabStop = false;
            this.BtnCategoria.Text = "CATEGORIA";
            this.BtnCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCategoria.UseVisualStyleBackColor = false;
            this.BtnCategoria.Click += new System.EventHandler(this.BtnCategoria_Click);
            // 
            // BtnMarca
            // 
            this.BtnMarca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMarca.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnMarca.FlatAppearance.BorderSize = 0;
            this.BtnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarca.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarca.Image = global::CapaPresentacion.Properties.Resources.talla_mediana;
            this.BtnMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMarca.Location = new System.Drawing.Point(745, 123);
            this.BtnMarca.Name = "BtnMarca";
            this.BtnMarca.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.BtnMarca.Size = new System.Drawing.Size(150, 35);
            this.BtnMarca.TabIndex = 46;
            this.BtnMarca.TabStop = false;
            this.BtnMarca.Text = "MARCA";
            this.BtnMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMarca.UseVisualStyleBackColor = false;
            this.BtnMarca.Click += new System.EventHandler(this.BtnMarca_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Image = global::CapaPresentacion.Properties.Resources.guardar;
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(1040, 531);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 35);
            this.BtnGuardar.TabIndex = 44;
            this.BtnGuardar.TabStop = false;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Visible = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAgregar.BackColor = System.Drawing.Color.Lime;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Image = global::CapaPresentacion.Properties.Resources.agregar_al_portapapeles_simbolo_de_interfaz_negro;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(421, 531);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(150, 35);
            this.BtnAgregar.TabIndex = 20;
            this.BtnAgregar.TabStop = false;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnCancelar.BackColor = System.Drawing.Color.Orange;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Image = global::CapaPresentacion.Properties.Resources.cancelar;
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(755, 531);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(160, 35);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.TabStop = false;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblAnadir
            // 
            this.LblAnadir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblAnadir.AutoSize = true;
            this.LblAnadir.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAnadir.ForeColor = System.Drawing.Color.White;
            this.LblAnadir.Location = new System.Drawing.Point(741, 375);
            this.LblAnadir.Name = "LblAnadir";
            this.LblAnadir.Size = new System.Drawing.Size(126, 23);
            this.LblAnadir.TabIndex = 52;
            this.LblAnadir.Text = "CATEGORIA";
            this.LblAnadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtAnadir
            // 
            this.TxtAnadir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TxtAnadir.BackColor = System.Drawing.Color.Black;
            this.TxtAnadir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAnadir.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnadir.ForeColor = System.Drawing.Color.White;
            this.TxtAnadir.Location = new System.Drawing.Point(876, 365);
            this.TxtAnadir.Multiline = true;
            this.TxtAnadir.Name = "TxtAnadir";
            this.TxtAnadir.Size = new System.Drawing.Size(180, 30);
            this.TxtAnadir.TabIndex = 80;
            this.TxtAnadir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtAnadir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnadir_KeyPress);
            // 
            // LspBuscar
            // 
            this.LspBuscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LspBuscar.BorderColor = System.Drawing.Color.DimGray;
            this.LspBuscar.BorderWidth = 3;
            this.LspBuscar.Enabled = false;
            this.LspBuscar.Name = "LspBuscar";
            this.LspBuscar.X1 = 870;
            this.LspBuscar.X2 = 1060;
            this.LspBuscar.Y1 = 398;
            this.LspBuscar.Y2 = 398;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.LspBuscar});
            this.shapeContainer1.Size = new System.Drawing.Size(1200, 575);
            this.shapeContainer1.TabIndex = 81;
            this.shapeContainer1.TabStop = false;
            // 
            // LblErrorElemento
            // 
            this.LblErrorElemento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LblErrorElemento.AutoSize = true;
            this.LblErrorElemento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblErrorElemento.ForeColor = System.Drawing.Color.Yellow;
            this.LblErrorElemento.Location = new System.Drawing.Point(742, 403);
            this.LblErrorElemento.Name = "LblErrorElemento";
            this.LblErrorElemento.Size = new System.Drawing.Size(182, 17);
            this.LblErrorElemento.TabIndex = 82;
            this.LblErrorElemento.Text = "Error de elemento a anadir";
            this.LblErrorElemento.Visible = false;
            // 
            // P_Anadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 575);
            this.Controls.Add(this.LblErrorElemento);
            this.Controls.Add(this.TxtAnadir);
            this.Controls.Add(this.LblAnadir);
            this.Controls.Add(this.BtnCargo);
            this.Controls.Add(this.BtnCategoria);
            this.Controls.Add(this.BtnMarca);
            this.Controls.Add(this.DtvAnadir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "P_Anadir";
            this.Opacity = 0.9D;
            this.Text = "Anadir";
            ((System.ComponentModel.ISupportInitialize)(this.DtvAnadir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.DataGridView DtvAnadir;
        private System.Windows.Forms.Button BtnMarca;
        private System.Windows.Forms.Button BtnCategoria;
        private System.Windows.Forms.Button BtnCargo;
        private System.Windows.Forms.Label LblAnadir;
        private System.Windows.Forms.TextBox TxtAnadir;
        private Microsoft.VisualBasic.PowerPacks.LineShape LspBuscar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label LblErrorElemento;
    }
}