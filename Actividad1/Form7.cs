using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            //añadido
            CargaComboModulo();
        }

        public void CargaComboModulo()
        {
            Estudiante xx = new Estudiante();
            try
            {
                cmbModulo.ValueMember = "MOD_ID";
                cmbModulo.DisplayMember = "Nombre";/////corespondee a el que se define en el "as Nombre" del script
                cmbModulo.DataSource = xx.CargaComboModulo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Btn_buscarModulo_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();
            DataTable lab = new DataTable();
            try
            {
                lab = es.CargarFormularioModulo(cmbModulo.SelectedValue.ToString());
                txtNombre.Text= lab.Rows[0]["mod_nombre"].ToString();//MOD_NOMBRE
                txtCodigo.Text=lab.Rows[0]["mod_codigo"].ToString();//MOD_CODIGO
                //para cargar el checkbox
                if (lab.Rows[0]["mod_activo"].ToString() == "True")
                {
                    chbModuloActivo.Checked = true;
                }else
                {
                    chbModuloActivo.Checked = false;
                }
                //para el chb

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Btn_ActualizarModulo_Click(object sender, EventArgs e)//Funcionaaaaaa
        {
            //primero
            Estudiante es = new Estudiante();
            string resultado = "";
            //segundo
            try
            {
                resultado = es.ActualizaModulo(
                    cmbModulo.SelectedValue.ToString(),
                    txtNombre.Text,
                      txtCodigo.Text,
                      chbModuloActivo.Checked);//funcionaaaa
                MessageBox.Show(resultado);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
