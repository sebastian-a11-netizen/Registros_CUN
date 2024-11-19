using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Registros_CUN
{
    internal class Conexion_DB
    {
        //string cadena = "Data Source=DESKTOP-SSFEG87\\SQLEXPRESS;Initial Catalog=DB_REGISTROS_CUN;Integrated Security=True";
        string cadena = @"Server=cucarachoso.ddns.net;Database=DB_REGISTROS_CUN;User ID=estudiante;Password=CUN_estudiante!;Integrated Security=False";

        public SqlConnection conexion = new SqlConnection();

        public Conexion_DB()
        {
            conexion.ConnectionString = cadena;
        }

        public void conectar()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Base de datos conectada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Por este motivo no se pudo conectar la base de datos: " + ex.Message);
            }
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public bool estado()
        {
            return conexion.State == ConnectionState.Open;
        }

        public void abrir_y_cerrar()
        {
            if (!estado())
            {
                conexion.Open();
            }
            else
            {
                conexion.Close();
                conexion.Open();
            }
        }

        public List<string> get_roles()
        {
            abrir_y_cerrar();
            List<string> roles = new List<string>();

            string query = "SELECT rol FROM Roles";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                roles.Add(reader["rol"].ToString());
            }

            return roles;
        }

        public List<string> get_tipo_documento()
        {
            abrir_y_cerrar();
            List<string> tipo_documento = new List<string>();

            string query = "SELECT tipo_documento FROM Tipos_documentos";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tipo_documento.Add(reader["tipo_documento"].ToString());
            }

            return tipo_documento;
        }

        public List<string> get_tipo_material()
        {
            abrir_y_cerrar();
            List<string> tipo_material = new List<string>();

            string query = "SELECT tipo_material FROM Tipo_material";
            SqlCommand command = new SqlCommand(query, conexion);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tipo_material.Add(reader["tipo_material"].ToString());
            }

            return tipo_material;
        }

        public bool set_persona(string nombres, string apellidos, int idTipoDocumento, string numeroDocumento, int idRol)
        {
            bool resultado = false;

            try
            {
                abrir_y_cerrar();
                string query = "INSERT INTO Personas (nombres, apellidos, id_tipo_documento, numero_documento, id_rol) " +
                               "VALUES (@nombres, @apellidos, @idTipoDocumento, @numeroDocumento, @idRol)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombres", nombres);
                    command.Parameters.AddWithValue("@apellidos", apellidos);
                    command.Parameters.AddWithValue("@idTipoDocumento", idTipoDocumento);
                    command.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);
                    command.Parameters.AddWithValue("@idRol", idRol);

                    int filasAfectadas = command.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar la persona: " + ex.Message);
            }

            return resultado;
        }

        public bool set_material(int idPersona, int idTipoMaterial, string serial, string color, string marca, string observaciones, bool estado)
        {
            bool resultado = false;

            try
            {
                abrir_y_cerrar();
                string query = "INSERT INTO Materiales (id_persona, id_tipo_material, serial, color, marca, observaciones, estado) " +
                               "VALUES (@idPersona, @idTipoMaterial, @serial, @color, @marca, @observaciones, @estado)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idPersona", idPersona);
                    command.Parameters.AddWithValue("@idTipoMaterial", idTipoMaterial);
                    command.Parameters.AddWithValue("@serial", serial);
                    command.Parameters.AddWithValue("@color", color);
                    command.Parameters.AddWithValue("@marca", marca);
                    command.Parameters.AddWithValue("@observaciones", observaciones);
                    command.Parameters.AddWithValue("@estado", estado);

                    int filasAfectadas = command.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar el material: " + ex.Message);
            }

            return resultado;
        }

        public DataTable get_materiales_persona(int idPersona)
        {
            DataTable dtMateriales = new DataTable();
            string query = @"
                            SELECT m.id_material, m.serial, m.color, m.marca, tm.tipo_material, m.observaciones, m.estado
                            FROM Materiales m
                            JOIN Tipo_material tm ON m.id_tipo_material = tm.id_tipo_material
                            WHERE m.id_persona = @idPersona";

            try
            {
                abrir_y_cerrar();
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dtMateriales);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los materiales: " + ex.Message);
            }

            return dtMateriales;
        }

        public int? GetIdPersonaPorCedula(string numeroDocumento)
        {
            string query = "SELECT id_persona FROM Personas WHERE numero_documento = @numeroDocumento";

            try
            {
                abrir_y_cerrar();
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar la persona: " + ex.Message);
            }
        }

        public string get_info_persona(int idPersona, string consulta)
        {
            string query;
            switch (consulta)
            {
                case "tipo_documento":
                    query = @"
                            SELECT td.tipo_documento 
                            FROM Personas p
                            JOIN Tipos_documentos td ON p.id_tipo_documento = td.id_tipo_documento
                            WHERE p.id_persona = @idPersona";
                    break;
                case "rol":
                    query = @"
                            SELECT r.rol 
                            FROM Personas p
                            JOIN Roles r ON p.id_rol = r.id_rol
                            WHERE p.id_persona = @idPersona";
                    break;
                default:
                    query = "SELECT " + consulta + " FROM Personas WHERE id_persona = @idPersona";
                    break;
            }

            try
            {
                abrir_y_cerrar();
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);

                object result = command.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar información de la persona: " + ex.Message);
                return null;
            }
        }

        public int? GetIdMaterialPorSerial(string serial)
        {
            string query = "SELECT id_material FROM Materiales WHERE serial = @serial";

            try
            {
                abrir_y_cerrar();
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@serial", serial);

                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el ID del material: " + ex.Message);
                return null;
            }
        }

        public void ActualizarEstadoMaterial(int idMaterial, bool estado)
        {
            string queryActualizarEstado = "UPDATE Materiales SET estado = @estado WHERE id_material = @idMaterial";
            string queryInsertarRegistro = @"
            INSERT INTO Registros (id_material, id_persona, estado, fecha, hora)
            VALUES (@idMaterial, (SELECT id_persona FROM Materiales WHERE id_material = @idMaterial), @estado, @fecha, @hora)";

            try
            {
                abrir_y_cerrar();

                // Actualizar el estado del material
                SqlCommand commandActualizar = new SqlCommand(queryActualizarEstado, conexion);
                commandActualizar.Parameters.AddWithValue("@estado", estado);
                commandActualizar.Parameters.AddWithValue("@idMaterial", idMaterial);
                commandActualizar.ExecuteNonQuery();

                // Insertar en la tabla Registros
                SqlCommand commandInsertarRegistro = new SqlCommand(queryInsertarRegistro, conexion);
                commandInsertarRegistro.Parameters.AddWithValue("@idMaterial", idMaterial);
                commandInsertarRegistro.Parameters.AddWithValue("@estado", estado);
                commandInsertarRegistro.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                commandInsertarRegistro.Parameters.AddWithValue("@hora", DateTime.Now.ToString("HH:mm:ss"));
                commandInsertarRegistro.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el estado del material: " + ex.Message);
            }
        }
    }
}
