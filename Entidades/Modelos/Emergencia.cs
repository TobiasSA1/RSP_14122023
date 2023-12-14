using Entidades.Enumerados;
using Entidades.MetodosDeExtension;

namespace Entidades.Modelos
{
    public class Emergencia
    {

        private EEmergencia tipo;
        private DateTime inicio;
        private bool estaAtendida;
        private static int tiempoLimiteEnSegundos;
        private double estadoEmergencia;


        public bool EstaAtendida { get => this.estaAtendida; set => this.estaAtendida = value; }
        public EEmergencia Tipo { get => this.tipo; }

        public string Imagen { get => $"./assets/{this.tipo}.gif"; }
        public DateTime Inicio { get => this.inicio; }
        public double EstadoEmergencia { get => this.estadoEmergencia; }
        public static double TiempoLimiteEnSegundos { get => Emergencia.tiempoLimiteEnSegundos; }

        public double SegundosTranscurridos
        {
            get
            {
                return this.inicio.SegundosTranscurridos();
            }
        }

        static Emergencia()
        {
            Emergencia.tiempoLimiteEnSegundos = 30;
        }
        public Emergencia(EEmergencia tipo)
        {
            this.tipo = tipo;
        }


        public void EmitirAlerta()
        {
            this.inicio = DateTime.Now;
        }
        public void ActualizarEstadoEmergencia()
        {
            this.estadoEmergencia = 1 - (this.SegundosTranscurridos / Emergencia.tiempoLimiteEnSegundos);
        }

    }
}
