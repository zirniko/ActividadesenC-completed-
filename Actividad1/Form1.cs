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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            Estudiante op = new Estudiante();
            //Aqui instancio la clase
            string mensaje = op.InsertaEstudiante(tbxNombreModulo.Text, 
                                                  tbxCodigoModulo.Text, 
                                                  chbActivo.Checked);

            MessageBox.Show(mensaje);

        }
    } 
}
