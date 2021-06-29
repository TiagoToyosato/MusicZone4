using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone4.Models
{
    public static class Repositorio
    {
        private static List<Banda> bandas = new List<Banda>();

        public static List<Banda> Bandas
        {
            get
            {
                List<Banda> cloneBandas = new List<Banda>(bandas);
                return cloneBandas;
            }
        }

        public static void AddBanda(Banda novaBanda)
        {
            bandas.Add(novaBanda);
        }

        public static int TotalBandas()
        {
            return bandas.Count();
        }

        public static int TotalBandasPop()
        {
            return bandas.Where(b => b.Genero == "Pop").Count();
        }
    }
}
