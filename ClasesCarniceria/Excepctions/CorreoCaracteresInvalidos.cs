using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.Excepctions
{
    public class CorreoCaracteresInvalidos : Exception
    {
        public CorreoCaracteresInvalidos()
        {
        }

        public CorreoCaracteresInvalidos(string? message) : base(message)
        {
        }

        public CorreoCaracteresInvalidos(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
