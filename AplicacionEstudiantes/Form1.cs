namespace AplicacionEstudiantes
{
    public partial class Form1 : Form
    {
        Estudiante[] estudiantes = new Estudiante[5];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (contador < 5)
            {
                bool verificado = true;

                if(txtCarnet.Text == "")
                {
                    lblErrorCarnet.Text = "El carnet no puede ser vacío";
                    lblErrorCarnet.Visible = true;
                    verificado= false;
                }

                if(txtNombre.Text == "")
                {
                    lblErrorNombre.Text = "El nombre no puede ser vacío";
                    lblErrorNombre.Visible = true;
                    verificado= false;
                }

                if (verificado)
                {
                    estudiantes[contador] = new Estudiante(txtCarnet.Text, txtNombre.Text);
                    contador++;

                    txtCarnet.Text = "";
                    txtNombre.Text = "";
                    lblErrorCarnet.Visible = false;
                    lblErrorNombre.Visible = false;
                }
            }
            else
            {
                lblError.Text = "No es posible almacenar más estudiantes";
                lblError.Visible = true;
            }
        }
    }
}