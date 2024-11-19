using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registros_CUN
{
    public partial class Inicio : Form
    {
        Conexion_DB db = new Conexion_DB();
        private Form1 form1;
        public Inicio(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            form1.abrir_from_hijo(new Registro(form1));
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            int? documento = db.GetIdPersonaPorCedula(tbx_documento.Text);
            if (documento == null)
            {
                MessageBox.Show("El usuario con numero de documento " + tbx_documento.Text + " no existe");
                tbx_documento.Clear();
            }
            else
            {
                form1.abrir_from_hijo(new Check(form1, Convert.ToInt32(documento)));
            }
        }

        private void lnkRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form1.abrir_from_hijo(new Registro(form1));
        }
    }
}
