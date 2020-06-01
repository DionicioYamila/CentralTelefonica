using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public class Local: Llamada 
    {
        protected float costo;

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj) 
        {
            return  (this == obj);
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
            return base.duracion * this.costo;
        }

        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo; 
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo:"+ this.costo);

            return sb.ToString();

        }
    }
}
