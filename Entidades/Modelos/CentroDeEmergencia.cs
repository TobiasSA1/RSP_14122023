using Entidades.Enumerados;
using Entidades.Excepciones;
using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class CentroDeEmergencia
    {
        private string nombre;
        private Emergencia emergenciaEnCurso;
        private List<Emergencia> emergenciasAtendidas;
        private CancellationTokenSource tokenSource;

        public event Action<Emergencia> OnEmergenciaEnCurso;
        public event Action<double> OnEstadoEmergenciaEnCurso;
        public event Action<string> OnServidorInvalido;

        public CentroDeEmergencia(string nombre)
        {
            this.nombre = nombre;
            this.emergenciasAtendidas = new List<Emergencia>();
        }

        public string Nombre { get => this.nombre; }
        public List<Emergencia> EmergenciasAtendidas { get => this.emergenciasAtendidas; }

        public void HabilitarIngreso()
        {
            EEmergencia tipoEmergencia = (EEmergencia)new Random().Next(Enum.GetNames(typeof(EEmergencia)).Length);
            this.emergenciaEnCurso = new Emergencia(tipoEmergencia);
            OnEmergenciaEnCurso?.Invoke(this.emergenciaEnCurso);
            tokenSource = new CancellationTokenSource();
            Task.Run(() => DarSeguimientoAEmergencia(tokenSource.Token));
        }

        private async void DarSeguimientoAEmergencia(CancellationToken cancellationToken)
        {
            while (true && emergenciaEnCurso.SegundosTranscurridos < Emergencia.TiempoLimiteEnSegundos && !this.emergenciaEnCurso.EstaAtendida)
            {
                await Task.Delay(1000, cancellationToken);
                this.emergenciaEnCurso.ActualizarEstadoEmergencia();
                NotificarEstadoDeEmergenciaEnCurso();
            }
        }

        public void DeshabilitarIngreso()
        {
            tokenSource?.Cancel();
        }

        public async void EnviarServidorPublico<T>(T servidorPublico) where T : IServidorPublico
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                try
                {
                    servidorPublico.Atender(this.emergenciaEnCurso);
                    this.emergenciasAtendidas.Add(this.emergenciaEnCurso);
                }
                catch (ServidorPublicoInvalidoException ex)
                {
                    OnServidorInvalido?.Invoke(ex.Message);
                }
            });
        }

        private void NotificarEstadoDeEmergenciaEnCurso()
        {
            OnEstadoEmergenciaEnCurso?.Invoke(this.emergenciaEnCurso.EstadoEmergencia);
        }
    }
}
