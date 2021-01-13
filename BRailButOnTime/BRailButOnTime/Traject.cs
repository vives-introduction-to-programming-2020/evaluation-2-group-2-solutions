using System;
using System.Collections.Generic;
using System.Text;

namespace BRailButOnTime
{
    public class Traject
    {
        public Traject(Location from, Location to)
        {
            this.from = from;
            this.to = to;
        }

        public Location GetFrom()
        {
            return from;
        }
        public Location GetTo()
        {
            return to;
        }
        public override string ToString()
        {
            return $"Traject from {from} to {to}";
        }

        private Location from = null;
        private Location to = null;
    }
}
