using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundGenerator
{
    public class Relative : Person
    {
        //Parents are 1, Grandparents 2...
        private int GenerationsBack;

        private int Position;
    }
}