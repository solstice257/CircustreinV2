using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        int totaalPunten;
        List<Dier> DierenInWagon;
        public Wagon()
        {
            DierenInWagon = new List<Dier>();
        }

        public bool GeenPlek(Dier dier)
        {
            if (dier.punten + totaalPunten < 11)
            {
                return false;
            }
            return true;
        }

        public bool GevaarLijkVoorDier(Dier dier)
        {
            if (DierenInWagon.Count != 0)
            {
                foreach (Dier dierInWagon in DierenInWagon)
                {
                    switch (dier.grootte)
                    {
                        default:
                            break;
                        case Grootte.Groot:
                            if (dierInWagon.type == Type.Carnivoor && dierInWagon.grootte == Grootte.Groot)
                            {
                                return true;
                            }
                            break;
                        case Grootte.Middel:
                            if (dierInWagon.type == Type.Carnivoor && (dierInWagon.grootte == Grootte.Groot || dierInWagon.grootte == Grootte.Middel))
                            {
                                return true;
                            }
                            break;
                        case Grootte.Klein:
                            if (dierInWagon.type == Type.Carnivoor)
                            {
                                return true;
                            }
                            break;
                    }
                }
            }
            return false;
        }

        public void VoegDierToe(Dier dier)
        {
            DierenInWagon.Add(dier);
            totaalPunten = totaalPunten + dier.punten;
        }
    }
}
