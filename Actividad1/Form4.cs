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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //añadio
            CargaComboLaboratorio();
        }
        //ESTE SE EDITAAAAAAAAAAAAAAAAA .ESTE ES EL QUE FUNCIONAA
        public void CargaComboLaboratorio()
        {
            Estudiante xx = new Estudiante();
            try
            {
                cmbLaboratorio.ValueMember = "lab_id";
                cmbLaboratorio.DisplayMember = "lab_piso";
                cmbLaboratorio.DataSource = xx.CargaComboLaboratorio();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //ESTE SE EDITAAAAAAAAAAAAAAAAA .ESTE ES EL QUE FUNCIONAA
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();
            DataTable lab = new DataTable();
            try
            {
                lab= es.CargaFormularioLaboratorio(cmbLaboratorio.SelectedValue.ToString());
                txtCapasidad.Text = lab.Rows[0]["lab_capacidad"].ToString();
                txtPiso.Text = lab.Rows[0]["lab_piso"].ToString();

                //para cargar el checkbox
                if (lab.Rows[0]["lab_esinformatica"].ToString() == "True")
                {
                    chbEsInformatica.Checked = true;
                }
                else
                {
                    chbEsInformatica.Checked = false;
                }
                //para el chb
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        private void btnActualizar_Click(object sender, EventArgs e)//realizado :)
        {
            //primero
            Estudiante es = new Estudiante();

            //añadido
            DataTable lab = new DataTable();
            string resultado = "";
            //segundo
            try
            {
                resultado = es.ActualizarLaboratorio
                    (cmbLaboratorio.SelectedValue.ToString(),
                    txtCapasidad.Text,
                          txtPiso.Text,
                           chbEsInformatica.Checked);
              
            
                MessageBox.Show(resultado);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
