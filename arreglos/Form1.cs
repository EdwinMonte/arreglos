namespace arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarVector_Click(object sender, EventArgs e)
        {
            int[] notas = new int[5];
            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;

            int suma = 0;
            double promedio;

            cboNotas.Items.Clear();
            for (int i = 0; i <= 4; i++)
            {
                cboNotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 5;
            txtPromedio.Text = Convert.ToString(promedio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            cboNotas.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
