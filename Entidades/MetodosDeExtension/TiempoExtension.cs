namespace Entidades.MetodosDeExtension
{
    public static class TiempoExtension
    {
        public static double SegundosTranscurridos(this DateTime inicio)
        {
            TimeSpan diferencia = DateTime.Now - inicio;
            return diferencia.TotalSeconds;
        }
    }
}
