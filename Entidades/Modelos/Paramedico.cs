using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.MetodosDeExtension;

namespace Entidades.Modelos
{
    public class Paramedico: IServidorPublico
    {
        public string Imagen => $"./assets/{this.GetType().Name}.gif";

        private static List<EEmergencia> emergenciasAtendibles;

        static Paramedico()
        {
            Paramedico.emergenciasAtendibles = new List<EEmergencia>() { EEmergencia.Accidentes_De_Trafico, EEmergencia.Desastres_Naturales, EEmergencia.Emergencias_Medicas };
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
