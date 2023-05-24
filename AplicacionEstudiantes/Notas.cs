using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEstudiantes
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            Curso nuevoCurso = new Curso(txtCurso.Text, Int32.Parse(txtNota.Text));
            Form1.instance.getListaEstudiantes().addCourse(txtCarnet.Text, nuevoCurso);

            txtCarnet.Text = "";
            txtCurso.Text = "";
            txtNota.Text = "";

            txtCarnet.Focus();
        }

    }
}
