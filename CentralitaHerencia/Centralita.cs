using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.GananciasPorLocal + this.GananciasPorProvincial;
                //return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        //private float CalcularGanancia(Llamada.TipoLlamada tipo)
        //{
        //    float acum = 0; 

        //    foreach (Llamada x in this.listaDeLlamadas)
        //    {
        //        //LOCAL
        //        if (tipo == Llamada.TipoLlamada.Local)
        //        {
        //            if (x is Local)
        //            {
        //                acum += ((Local)x).CostoLlamada;
        //            }
        //        }
        //        //PROVINCIAL
        //        else if (tipo == Llamada.TipoLlamada.Provincial)
        //        {
        //            if (x is Provincial)
        //            {
        //                acum += ((Provincial)x).CostoLlamada;
        //            }
        //        }
        //        //TODAS
        //        else
        //        {
        //            if (x is Local) 
        //            {
        //                acum += ((Local)x).CostoLlamada;
        //            }
        //            else
        //            {
        //                acum += ((Provincial)x).CostoLlamada;
        //            }
        //        }
        //    }

        //    return acum;
        //}

        //private float CalcularGanancia(Llamada.TipoLlamada tipo)
        //{
        //    float acum = 0;

        //    foreach (Llamada x in this.listaDeLlamadas)
        //    {
        //        //LOCAL
        //        if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
        //        {
        //            if (x is Local)
        //            {
        //                acum += ((Local)x).CostoLlamada;
        //            }
        //        }
        //        //PROVINCIAL
        //        else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
        //        {
        //            if (x is Provincial)
        //            {
        //                acum += ((Provincial)x).CostoLlamada;
        //            }
        //        }
        //    }

        //    return acum;
        //} 

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acum = 0;

            foreach (Llamada x in this.listaDeLlamadas)
            {
                //LOCAL
                if (tipo == Llamada.TipoLlamada.Local)
                {
                    if (x is Local)
                    {
                        acum += ((Local)x).CostoLlamada;
                    }
                }
                //PROVINCIAL
                else if (tipo == Llamada.TipoLlamada.Provincial)
                {
                    if (x is Provincial)
                    {
                        acum += ((Provincial)x).CostoLlamada;
                    }
                }
                //TODAS(SUMO LOCAL Y PROVINCIAL EN EL GETTER)
            }

            return acum;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon Social:" + this.razonSocial);
            sb.AppendLine("Ganancia Total:" + this.GananciasPorTotal);
            sb.AppendLine("Ganancia Provincial:" + this.GananciasPorProvincial);
            sb.AppendLine("Ganancia Local:" + this.GananciasPorLocal);

            foreach (Llamada l in listaDeLlamadas)
            {
                sb.AppendLine("Detalle de Llamada:" + l.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamadas(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach (Llamada aux in c.listaDeLlamadas)
            {
                if (aux == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                throw new CentralitaException("mensajito","Centralita","estoy en el +");       
            }

            c.AgregarLlamadas(llamada);
            return c;
        }
    }
}
