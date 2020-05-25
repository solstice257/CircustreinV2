using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Circustrein
{
    public class Trein
    {
        public readonly List<Wagon> Wagons;
        Wagon Wagon;
        public Trein()
        {
            Wagons = new List<Wagon>();
            //Wagons.Add(new Wagon());
        }

        private Wagon MaakWagon()
        {
            Wagon = new Wagon();
            return Wagon;
        }
        public void DierToevoegenWagon(List<Dier> Dieren)
        {
            foreach (Dier dier in OrderList(Dieren))
            {
                WagonMetPlek(dier);
            }
        }

        public Wagon WagonMetPlek(Dier dier)
        {
            {
                foreach (Wagon wagon in Wagons)
                { 
                    if (!wagon.GeenPlek(dier))
                    {
                        if (!wagon.GevaarLijkVoorDier(dier))
                        {
                            wagon.VoegDierToe(dier);
                            return wagon;
                        }
                    }
                }
            }
            Wagon a = MaakWagon();
            a.VoegDierToe(dier);
            Wagons.Add(a);
            return a;
        }

        public List<Dier> OrderList(List<Dier> Dieren)
        {
            List<Dier> KleineDieren = new List<Dier>();

            
            Dieren = Dieren.OrderBy(c => c.grootte).ToList();
            Dieren = Dieren.OrderBy(c => c.type).ToList();
            for (int i = 0; i < Dieren.Count; i++)
            {
                if (Dieren[i].grootte == Grootte.Klein)
                {
                    KleineDieren.Add(Dieren[i]);
                    Dieren.Remove(Dieren[i]);
                    i--;
                }
            }
            Dieren.AddRange(KleineDieren);
            return Dieren;
        }
    }
}
