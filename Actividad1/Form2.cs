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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante op = new Estudiante();
            DataTable lab = new DataTable();
            //haci instancio la clase
            string mensaje = op.InsertaLaboratorio
                (tbxCapacidad.Text,
                  tbxPiso.Text,
                   chbEsInformatica.Checked);

            MessageBox.Show(mensaje);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
