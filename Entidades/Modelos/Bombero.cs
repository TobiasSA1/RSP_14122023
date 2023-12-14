using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class Bombero: IServidorPublico
    {
        public string Imagen => $"./assets/{this.GetType().Name}.gif";

        public void Atender(Emergencia emergencia)
        {
            emergencia.EstaAtendida = true;
        }
    }
}
