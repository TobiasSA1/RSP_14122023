using System.Text.Json;
using System.Xml;

namespace Entidades.Archivos
{
    public static class GestorDeArchivos
    {

        private static readonly string basePath;

        static GestorDeArchivos()
        {
            basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "14122023_Alumno");
            ValidaExistenciaDeDirectorio();
        }

        private static void ValidaExistenciaDeDirectorio()
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
        }

        private static void Guardar(string informacion, string path)
        {
            string filePath = Path.Combine(basePath, path);
            File.WriteAllText(filePath, informacion);
        }

        public static void Serializar<T>(T elemento, string nombreArchivo)
        {

                string jsonData = JsonSerializer.Serialize(elemento);
                Guardar(jsonData, nombreArchivo);

        }
    }
}
