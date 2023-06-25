using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.Excepctions
{
    public class CorreoCantidadDeCaracteresException : Exception
    {
        public CorreoCantidadDeCaracteresException()
        {
        }

        public CorreoCantidadDeCaracteresException(string? message) : base(message)
        {
        }

        public CorreoCantidadDeCaracteresException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
