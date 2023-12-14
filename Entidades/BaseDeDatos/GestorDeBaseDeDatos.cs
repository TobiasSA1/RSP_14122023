using System.Data.SqlClient;

namespace Entidades.BaseDeDatos
{
    public static class GestorDeBaseDeDatos
    {
        private static readonly SqlConnection connection;
        private static readonly string stringConnection;

        static GestorDeBaseDeDatos()
        {
            stringConnection = "Server=DESKTOP-488DPB0\\SQLEXPRESS;Database=20230622SP;Trusted_Connection=True";

            connection = new SqlConnection(stringConnection);
        }
        public static bool RegistrarTrabajo(string nombreAlumno, int cantidadPacientes)
        {
            try
            {
                connection.Open();

                string query = $"INSERT INTO Trabajos (alumno, pacientes_atendidos) VALUES ('{nombreAlumno}', {cantidadPacientes})";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
