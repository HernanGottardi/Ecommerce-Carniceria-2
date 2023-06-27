using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.Excepctions
{
    public class CantidadDeCaracteresException : Exception
    {
        public CantidadDeCaracteresException()
        {
        }

        public CantidadDeCaracteresException(string? message) : base(message)
        {
        }

        public CantidadDeCaracteresException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
