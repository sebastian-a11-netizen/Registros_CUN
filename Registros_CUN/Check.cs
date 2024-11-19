using System;
using System.Data;
using System.Windows.Forms;

namespace Registros_CUN
{
    public partial class Check : Form
    {
        Conexion_DB db = new Conexion_DB();
        private Form1 form1;
        int id_persona = 0;

        public Check(Form1 form1, int id_persona)
        {
            InitializeComponent();
            this.form1 = form1;
            this.id_persona = id_persona;
        }

        private void Check_Load(object sender, EventArgs e)
        {
            // Cargar información de la persona en los controles
            lbl_nombres.Text = db.get_info_persona(id_persona, "nombres");
            lbl_apellidos.Text = db.get_info_persona(id_persona, "apellidos");
            lbl_tipo_documento.Text = db.get_info_persona(id_persona, "tipo_documento");
            lbl_numero_documento.Text = db.get_info_persona(id_persona, "numero_documento");
            lbl_rol.Text = db.get_info_persona(id_persona, "rol");
            MostrarMateriales(id_persona);
            ConfigurarDataGridView(); // Configura el DataGridView para su uso
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            // Regresar al formulario anterior
            form1.abrir_from_hijo(new Inicio(form1));
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            // Abrir el formulario para registrar nuevos materiales
            form1.abrir_from_hijo(new Registrar_Material(form1, id_persona));
        }

        private void MostrarMateriales(int idPersona)
        {
            // Obtener los materiales de la persona desde la base de datos
            DataTable materiales = db.get_materiales_persona(idPersona);

            if (materiales.Rows.Count > 0)
            {
                dataGridView1.DataSource = materiales; // Asignar los datos al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron materiales para esta persona.");
                dataGridView1.DataSource = null; // Limpiar el DataGridView si no hay datos
            }
        }

        private void ConfigurarDataGridView()
        {
            // Permitir selección múltiple y configuración de DataGridView
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Configurar la columna de estado con checkbox
            DataGridViewCheckBoxColumn estadoColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "estado" // Asumir que la tabla tiene una columna llamada "estado"
            };
            dataGridView1.Columns.Add(estadoColumn); // Añadir la columna al DataGridView
        }

        private void btn_aplicar_cambios_Click(object sender, EventArgs e)
        {
            // Aplicar cambios en el estado de los materiales seleccionados
            foreach (DataGridViewRow fila in dataGridView1.SelectedRows)
            {
                int idMaterial = Convert.ToInt32(fila.Cells["id_material"].Value);
                bool nuevoEstado = Convert.ToBoolean(fila.Cells["Estado"].Value);

                // Llama al método para actualizar el estado y registrar el cambio
                db.ActualizarEstadoMaterial(idMaterial, nuevoEstado);
            }

            MessageBox.Show("Estados actualizados y registros creados correctamente.");
        }
    }
}
