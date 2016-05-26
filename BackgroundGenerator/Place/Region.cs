using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundGenerator
{
    internal class Region : Place
    {
        //0 in Burg/borough (rare), 1 is City/Town, 2 is Barony, 3 County, 4 State (rare), 5 Nation
        public int Ordinal;

        public Guid? RegionOf;
        public Person PrimaryRuler;
    }
}