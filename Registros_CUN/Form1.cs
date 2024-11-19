namespace Registros_CUN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abrir_from_hijo(new Inicio(this));
        }
        public void abrir_from_hijo(Form formulario)
        {
            pnl_main.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnl_main.Controls.Add(formulario);

            formulario.Show();
        }
    }
}
