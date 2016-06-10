using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundGenerator
{
    public abstract class Place
    {
        public Guid PlaceId;
        public string Name;
        public Climate LocalClimate;
    }
}