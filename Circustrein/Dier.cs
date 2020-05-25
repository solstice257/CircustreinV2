using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Dier
    {
        public Type type;
        public Grootte grootte;
        public int punten;

        public Dier(Type type, Grootte grootte, int punten)
        {
            this.type = type;
            this.grootte = grootte;
            this.punten = punten;
        }
    }
}
