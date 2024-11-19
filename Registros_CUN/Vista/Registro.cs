using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Registros_CUN
{
    public partial class Registro : Form
    {
        Conexion_DB db = new Conexion_DB();
        private Form1 form1;
        public Registro(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Registro_Load(object sender, EventArgs e)
        {

            db.conectar();
            tmr_estado_db.Start();
            cbx_rol.Items.Clear();
            cbx_tipo_documento.Items.Clear();
            foreach (string rol in db.get_roles())
            {
                cbx_rol.Items.Add(rol);
            }
            foreach (string tipo_documento in db.get_tipo_documento())
            {
                cbx_tipo_documento.Items.Add(tipo_documento);
            }
        }

        private void tmr_estado_db_Tick(object sender, EventArgs e)
        {
            if (db.estado())
            {
                lbl_estado_db.ForeColor = Color.DarkGreen;
                lbl_estado_db.Text = "En linea";
            }
            else
            {
                lbl_estado_db.ForeColor = Color.DarkRed;
                lbl_estado_db.Text = "Desconectado";
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int id_persona = Convert.ToInt32(db.GetIdPersonaPorCedula(tbx_numero_documento.Text));
            if (tbx_nombres.Text == "" || tbx_apellidos.Text == "" || tbx_numero_documento.Text == "" || cbx_rol.SelectedIndex < 0 || cbx_tipo_documento.SelectedIndex < 0)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                
                if (id_persona !=0)
                {
                    MessageBox.Show("El numero de documento: "+tbx_numero_documento.Text+" ya existe y está asociado a \n \n" +
                            db.get_info_persona(id_persona, "nombres")+
                            db.get_info_persona(id_persona, "apellidos")+ "\n" +
                            "Tipo de documento: "+db.get_info_persona(id_persona, "tipo_documento")+ "\n" +
                            "Numero de documento: "+db.get_info_persona(id_persona, "numero_documento")+ "\n" +
                            "Rol: "+db.get_info_persona(id_persona, "rol")
                         );
                }
                else
                {
                    if (db.set_persona(tbx_nombres.Text, tbx_apellidos.Text, (cbx_tipo_documento.SelectedIndex + 1), tbx_numero_documento.Text, (cbx_rol.SelectedIndex + 1)))
                    {
                        MessageBox.Show(tbx_nombres.Text + " " + tbx_apellidos.Text + ". \nSe agregado correctamente");
                        form1.abrir_from_hijo(new Check(form1, Convert.ToInt32(db.GetIdPersonaPorCedula(tbx_numero_documento.Text))));
                    }
                    else
                    {
                        MessageBox.Show("No se ha logrado ingresar la persona, sabrá Dios por qué.");
                    }
                }
            }
        }

        public bool es_numero(string num)
        {
            try
            {
                int a = Convert.ToInt32(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            form1.abrir_from_hijo(new Inicio(form1));
        }
    }
}
