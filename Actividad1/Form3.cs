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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CargaComboModulo();
            CargaComboLaboratorio();
        }

        public void CargaComboModulo()//funciona
        {
            Estudiante xx = new Estudiante();
            try
            {
                cmbModulo.ValueMember = "Mod_Id";
                cmbModulo.DisplayMember = "Nombre";
                cmbModulo.DataSource = xx.CargaComboModulo();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public void CargaComboLaboratorio()//funcionaaaaaaaaaaaaaaaaaaaaa
        {
            Estudiante xx = new Estudiante();
            try
            {
                cmbLaboratorio.ValueMember = "lab_id";// original =Lab_Id
                cmbLaboratorio.DisplayMember = "lab_piso";//original=Nombre
                cmbLaboratorio.DataSource = xx.CargaComboLaboratorio();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
