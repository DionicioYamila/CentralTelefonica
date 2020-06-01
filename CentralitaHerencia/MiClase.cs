using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class MiClase
    {
        static int miMetodo()
        {
            throw new DivideByZeroException("Se dividio por cero amego");
        }

        public MiClase()
        {
            try
            {
                MiClase.miMetodo();
            }
            catch (Exception ex)
            {
                throw new DivideByZeroException("", ex);
            }
        }

        public MiClase(string p)
        {
            try
            {
                MiClase c = new MiClase();
            }
            catch (Exception ex)
            {
                
                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace.ToString());
                //Console.WriteLine("");
                throw new UnaException("", ex);
            }
        }
















    }
}
