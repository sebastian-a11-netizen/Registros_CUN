using Registros_CUN;
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
    public partial class Registrar_Material : Form
    {
        Conexion_DB db = new Conexion_DB();
        private Form1 form1;
        int id_persona;
        public Registrar_Material(Form1 form1, int id_persona)
        {
            InitializeComponent();
            this.form1 = form1;
            this.id_persona = id_persona;
        }

        private void Registrar_Material_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_cual.Visible = false;
            tbx_cual.Visible = false;
            db.conectar();
            cbx_tipo_material.Items.Clear();
            foreach (string tipo_material in db.get_tipo_material())
            {
                cbx_tipo_material.Items.Add(tipo_material);
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            form1.abrir_from_hijo(new Check(form1, id_persona));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbx_tipo_material.Text == "Otro")
            {
                tbx_cual.Visible = true;
                lbl_cual.Visible = true;
            }
            else
            {
                lbl_cual.Visible = false;
                tbx_cual.Visible = false;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int id_material = Convert.ToInt32(db.GetIdMaterialPorSerial(tbx_serial.Text));
            if (tbx_serial.Text == "" || tbx_marca.Text == "" || tbx_color.Text == "" || cbx_tipo_material.SelectedIndex < 0)
            {
                if (tbx_cual.Visible == true && tbx_cual.Text != "")
                {
                    MessageBox.Show("Complete todos los campos");
                }
            }
            else
            {
                if (id_material != 0)
                {
                    MessageBox.Show("El numero de serial: " + tbx_serial.Text + " ya existe y está asociado a \n \n" +
                            db.get_info_persona(id_persona, "nombres") +
                            db.get_info_persona(id_persona, "apellidos") + "\n" +
                            "Tipo de documento: " + db.get_info_persona(id_persona, "tipo_documento") + "\n" +
                            "Numero de documento: " + db.get_info_persona(id_persona, "numero_documento") + "\n" +
                            "Rol: " + db.get_info_persona(id_persona, "rol")
                         );
                }
                else
                {
                    if (db.set_material(id_persona, (cbx_tipo_material.SelectedIndex + 1), tbx_serial.Text, tbx_color.Text, tbx_marca.Text, tbx_cual.Text, false))
                    {
                        MessageBox.Show(tbx_serial.Text + " " + tbx_marca.Text + ". \nSe agregado correctamente");
                        form1.abrir_from_hijo(new Check(form1, id_persona));
                    }
                    else
                    {
                        MessageBox.Show("No se ha logrado ingresar el material, sabrá Dios por qué.");
                    }
                }  
            }
        }
    }
}
