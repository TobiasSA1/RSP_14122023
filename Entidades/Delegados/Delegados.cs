using Entidades.Modelos;

namespace Entidades.Delegados
{
    public delegate void DelegadoEmergenciaMensaje(string mensaje);

    public delegate void DelegadoEmergenciaEnCurso(Emergencia emergencia);

    public delegate void DelegadoEstadoEmergenciaEnCurso(double estado);
}