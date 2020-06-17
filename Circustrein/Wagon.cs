using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        int TotaalPuntenWagon;
        public ReadOnlyCollection<Dier> alleDierenInWagon;
        List<Dier> DierenInWagon;
        public Wagon()
        {
            DierenInWagon = new List<Dier>();
        }

        public bool GeenPlek(Dier dier)
        {
            if (dier.punten + TotaalPuntenWagon < 11)
            {
                return false;
            }
            return true;
        }

        public bool GevaarlijkVoorDier(Dier dier)
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
            TotaalPuntenWagon = TotaalPuntenWagon + dier.punten;
            alleDierenInWagon = DierenInWagon.AsReadOnly();
        }
    }
}
