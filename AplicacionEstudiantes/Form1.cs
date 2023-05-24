namespace AplicacionEstudiantes
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        MyLinkedList listaEstudiantes = new MyLinkedList("Estudiantes");

        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!listaEstudiantes.existNode(txtCarnet.Text))
            {

                bool verificado = true;

                if (txtCarnet.Text == "")
                {
                    lblErrorCarnet.Text = "El carnet no puede ser vacío";
                    lblErrorCarnet.Visible = true;
                    verificado = false;
                }

                if (txtNombre.Text == "")
                {
                    lblErrorNombre.Text = "El nombre no puede ser vacío";
                    lblErrorNombre.Visible = true;
                    verificado = false;
                }

                if (verificado)
                {
                    Estudiante nuevoEstudiante = new Estudiante(txtCarnet.Text, txtNombre.Text);
                    Node nuevoNodo = new Node(nuevoEstudiante);
                    listaEstudiantes.Add(nuevoNodo);

                    txtCarnet.Text = "";
                    txtNombre.Text = "";
                    lblErrorCarnet.Visible = false;
                    lblErrorNombre.Visible = false;

                    txtCarnet.Focus();
                }
            }
            else
            {
                lblError.Text = "Existe un estudiante registrado con el mismo carnet";
                lblError.Visible = true;
            }
        }

        private void mnuNotas_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            notas.Show();
        }

        public MyLinkedList getListaEstudiantes()
        {
            return listaEstudiantes;
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            string message = "";

            message += listaEstudiantes.getNodeList();

            MessageBox.Show(message);
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            String message = "¿Está seguro que desea salir?";
            String title = "Cerrar aplcación";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result = MessageBox.Show(message, title, buttons, icon);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}