using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundGenerator
{
    internal class Culture : Place
    {
        public enum Type
        {
            Dwarf,
            Halfling,
            Arthurian,
            Norse,
            Greek,
            Roman,
        }
    }
}