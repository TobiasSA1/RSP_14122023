using Entidades.Modelos;

namespace Entidades.Interfaces
{
    public interface IServidorPublico
    {
        string Imagen { get; }

        void Atender(Emergencia emergencia);
    }
}
