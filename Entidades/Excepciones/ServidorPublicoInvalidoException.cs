namespace Entidades.Excepciones
{
    public class ServidorPublicoInvalidoException : Exception
    {
        public ServidorPublicoInvalidoException(string? message) : this(message, null)
        {
        }

        public ServidorPublicoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
