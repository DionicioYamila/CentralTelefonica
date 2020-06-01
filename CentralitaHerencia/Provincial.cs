using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja franjaHoraria;

        public override bool Equals(object obj)
        {
            return (this == obj);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override float CostoLlamada
        {
            get
            {
               return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            if (franjaHoraria == Franja.Franja_1)
            {
                return base.duracion * 0.99f;
            }
            else if (franjaHoraria == Franja.Franja_2)
            {
                return base.duracion * 1.25f;
            }
            else
            {
                return base.duracion * 0.66f;
            }
        }

        protected new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja horaria:" +this.franjaHoraria);
            sb.AppendLine("Costo de Llamada:" +this.CostoLlamada);

            return sb.ToString();
        }
        public Provincial(Franja miFranja, Llamada llamada): this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }


    }
}
