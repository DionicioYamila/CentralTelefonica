using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        public enum TipoLlamada { Local, Provincial, Todas }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }


        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino 
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDuracion, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDuracion;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duracion:" + this.duracion);
            sb.AppendLine("Numero de destino:" + this.nroDestino);
            sb.AppendLine("Numero de origen:" + this.nroOrigen);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion < llamada2.duracion)
            {
                return -1;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else 
            {
                return 0;
            }
        }

        public static bool operator ==(Llamada l1, Llamada l2) 
        {
            return (l1.Equals(l2)) && (l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen); 
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


    }
}
