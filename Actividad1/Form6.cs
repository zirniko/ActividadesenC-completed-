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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            CargaComboModulo();

        }
        public void CargaComboModulo()
        {
            Estudiante es = new Estudiante();
            try
            {
                cmbModulo.ValueMember = "Mod_Id";
                cmbModulo.DisplayMember = "Nombre";
                cmbModulo.DataSource = es.CargaComboModulo();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           // Estudiante xx = new Estudiante();
            Estudiante es = new Estudiante();
            try
            {
                //dgvEstudiante.DataSource = xx.CargaGrillaPorModulo(cmbModulo.SelectedValue.ToString());
                dtvModulo.DataSource = es.CargaEnGrilla();

                /*

                if (dtvModulo.Rows.Count>0)//pregunto si el control gridview tiene datos o tiene alguna fila.
                {
                    panelGrilla.Visible = true;
                }
                else
                {
                    panelGrilla.Visible = false;
                }


                */
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
