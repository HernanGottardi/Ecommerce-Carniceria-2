namespace ClasesCarniceria.Excepctions
{
    public class TextoNuloException : Exception
    {
        public TextoNuloException()
        {
        }

        public TextoNuloException(string? message) : base(message)
        {
        }

        public TextoNuloException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
