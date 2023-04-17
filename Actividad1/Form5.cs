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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CargaComboLaboratorio();
        }
        public void CargaComboLaboratorio()
        {
            Estudiante xx = new Estudiante();
            try
            {
                cmbLaboratorio.ValueMember = "LAB_ID";
                cmbLaboratorio.DisplayMember = "LAB_PISO";
                cmbLaboratorio.DataSource = xx.CargaComboLaboratorio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Estudiante es = new Estudiante();
            DataTable lab = new DataTable();
            try
            {
                lab = es.CargaFormularioLaboratorio(cmbLaboratorio.SelectedValue.ToString());
                txtCapacidad.Text = lab.Rows[0]["LAB_CAPACIDAD"].ToString();
                txtPiso.Text = lab.Rows[0]["LAB_PISO"].ToString();

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
    }
}
