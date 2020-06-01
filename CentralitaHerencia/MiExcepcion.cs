using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class MiExcepcion: Exception
    {
        public MiExcepcion(string mensaje) : this(mensaje, null)
        {
        }

        public MiExcepcion(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
        }








    }
}
