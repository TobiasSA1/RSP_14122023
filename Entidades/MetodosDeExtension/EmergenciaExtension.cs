using Entidades.Enumerados;

namespace Entidades.MetodosDeExtension
{
    public static class EmergenciaExtension
    {
        public static bool ValidaEmergencia(this List<EEmergencia> lista, EEmergencia eEmergencia)
        {
            return lista.Any(emergencia => emergencia.Equals(eEmergencia));
        }
    }
}
