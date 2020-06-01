using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class UnaException : Exception
    {

        public UnaException(string mensaje): this(mensaje, null)
        {
        }

        public UnaException(string mensaje, Exception innerException):base(mensaje, innerException)
        {
        }











    }
}
