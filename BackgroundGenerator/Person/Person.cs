using System;
using System.Collections.Generic;

namespace BackgroundGenerator
{
    public abstract class Person
    {
        public Guid PersonalId;
        public Race Race;

        public string Title;
        public string GivenName; //Generally assumed as ordinal 1
        public string FamilyName;
        public string NameSuffix;
        public List<OrderedName> OrderedNames;
        public List<Relative> Siblings;
        public List<Relative> Relatives;
        public PersonalTimeline Timeline;
    }
}