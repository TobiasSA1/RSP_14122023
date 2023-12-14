using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;

namespace Entidades.Modelos
{
    public class Policia: IServidorPublico
    {

        public string Imagen => $"./assets/{this.GetType().Name}.gif";

        private static List<EEmergencia> emergenciasAtendibles;

        static Policia()
        {
            Policia.emergenciasAtendibles = new List<EEmergencia>() { EEmergencia.Accidentes_De_Trafico, EEmergencia.Rescates };
        }

        public void Atender(Emergencia emergencia)
        {
            if (emergenciasAtendibles.ValidaEmergencia(emergencia.Tipo))
            {
                emergencia.EstaAtendida = true;
            }
            else
            {
                throw new ServidorPublicoInvalidoException("El servidor público no puede atender este tipo de emergencias");
            }
        }
    }
}
