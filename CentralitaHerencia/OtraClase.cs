using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class OtraClase
    {

        public void otroMetodo()
        {
            try
            {
                MiClase c = new MiClase("yamila");
            }
            catch (Exception ex)
            {
                throw new MiExcepcion("", ex);
            }
        }








    }
}
