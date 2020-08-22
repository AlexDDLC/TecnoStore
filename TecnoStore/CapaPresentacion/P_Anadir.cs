using CapaNegocio;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class P_Anadir : Form
    {
        bool Marca = false;
        bool Categoria = false;
        bool Cargo = false;

        public P_Anadir()
        {
            InitializeComponent();
        }

        //
        public void MET_MostrarMarca()
        {
            CN_Acciones INST_MostrarMarcas = new CN_Acciones();
            DtvAnadir.DataSource = INST_MostrarMarcas.MET_MostrarMarcas();
        }

        public void MET_MostrarCategoria()
        {
            CN_Acciones INST_MostrarCategoria = new CN_Acciones();
            DtvAnadir.DataSource = INST_MostrarCategoria.MET_MostrarCategoria();
        }

        public void MET_MostrarCargo()
        {
            CN_Acciones INST_MostrarCargo = new CN_Acciones();
            DtvAnadir.DataSource = INST_MostrarCargo.MET_MostrarCargos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            BtnCancelar.Visible = true;
            BtnGuardar.Visible = true;
            BtnAgregar.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            BtnAgregar.Visible = true;
            BtnCancelar.Visible = false;
            BtnGuardar.Visible = false;
            LblErrorElemento.Visible = false;
            TxtAnadir.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BtnAgregar.Visible = true;
            BtnCancelar.Visible = false;
            BtnGuardar.Visible = false;

            if (Marca == true)
            {
                if (TxtAnadir.Text != "")
                {
                    try
                    {
                        CN_Acciones INST_InsertarMarca = new CN_Acciones();
                        INST_InsertarMarca.MET_InsertarMarca(TxtAnadir.Text);
                        MET_MostrarMarca();

                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("OCURRIO UN ERROR" + Error);
                        MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    LblErrorElemento.Visible = true;
                    LblErrorElemento.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
                    return;
                }
            }
            else if (Categoria == true)
            {
                if (TxtAnadir.Text != "")
                {
                    try
                    {
                        CN_Acciones INST_InsertarCategoria = new CN_Acciones();
                        INST_InsertarCategoria.MET_InsertarCategoria(TxtAnadir.Text);
                        MET_MostrarCategoria();
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("OCURRIO UN ERROR" + Error);
                        MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    LblErrorElemento.Visible = true;
                    LblErrorElemento.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
                    return;
                }
            }
            else if (Cargo == true)
            {
                if (TxtAnadir.Text != "")
                {
                    try
                    {
                        CN_Acciones INST_InsertarCargo = new CN_Acciones();
                        INST_InsertarCargo.MET_InsertarCargo(TxtAnadir.Text);
                        MET_MostrarCargo();
                    }
                    catch (Exception)
                    {
                        //MessageBox.Show("OCURRIO UN ERROR" + Error);
                        MessageBox.Show("Hay Un error en los datos introducidos. Verifique que todo este correcto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    LblErrorElemento.Visible = true;
                    LblErrorElemento.Text = "ESTE CAMPO NO PUEDE ESTAR VACIO";
                    return;
                }
            }
            TxtAnadir.Clear();
        }

        private void BtnMarca_Click(object sender, EventArgs e)
        {
            Marca = true;
            Categoria = false;
            Cargo = false;
            LblAnadir.Text = "MARCA";
            MET_MostrarMarca();
        }

        private void BtnCargo_Click(object sender, EventArgs e)
        {
            Marca = false;
            Categoria = false;
            Cargo = true;
            LblAnadir.Text = "CARGO";
            MET_MostrarCargo();
        }

        private void BtnCategoria_Click(object sender, EventArgs e)
        {
            Marca = false;
            Categoria = true;
            Cargo = false;
            LblAnadir.Text = "CATEGORIA";
            MET_MostrarCategoria();
        }

        private void TxtAnadir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}