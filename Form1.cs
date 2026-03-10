namespace SobrecargaOperadores_2026_II
{
    public partial class Form1 : Form
    {
        private Complejo c1;
        private Complejo c2;
        private Complejo c3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            c1 = Complejo.Leer(txtbOperando1.Text);
            c2 = Complejo.Leer(txtbOperando2.Text);
            c3 = c1 + c2;
            
            lbResultado.Text = c3.ToString();

        }
    }
}
