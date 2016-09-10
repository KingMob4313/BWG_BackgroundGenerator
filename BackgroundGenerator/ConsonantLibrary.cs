using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundGenerator
{
    public static class ConsonantLibrary
    {
        public static IDictionary<string, string> FourConsonantDictionary()
        {
            //Total brute force way to do this.
            //This will have to be replaced with a database action
            //to fill a dictionary.
            IDictionary<string, string> currentFourConsonantDictionary = new Dictionary<string, string>();
            currentFourConsonantDictionary.Add("Schw", "Zh");
            currentFourConsonantDictionary.Add("Schw", "Zw");
            currentFourConsonantDictionary.Add("Schw", "Sw");
            return currentFourConsonantDictionary;
        }

        public static IDictionary<string, string> ThreeConsonantDictionary()
        {
            //Total brute force way to do this.
            //This will have to be replaced with a database action
            //to fill a dictionary.
            IDictionary<string, string> currentThreeConsonantDictionary = new Dictionary<string, string>();
            currentThreeConsonantDictionary.Add("Thr", "T");
            currentThreeConsonantDictionary.Add("Sch", "Sh");
            currentThreeConsonantDictionary.Add("Spr", "Fr");
            return currentThreeConsonantDictionary;
        }

        public static IDictionary<string, string> TwoConsonantDictionary()
        {
            //Total brute force way to do this.
            //This will have to be replaced with a database action
            //to fill a dictionary.
            IDictionary<string, string> currentTwoConsonantDictionary = new Dictionary<string, string>();
            currentTwoConsonantDictionary.Add("Ca", "Ha");
            currentTwoConsonantDictionary.Add("Co", "Ho");
            currentTwoConsonantDictionary.Add("Fr", "Th");
            currentTwoConsonantDictionary.Add("Ga", "Wa");
            currentTwoConsonantDictionary.Add("Ga", "Ha");
            currentTwoConsonantDictionary.Add("Go", "Ho");
            currentTwoConsonantDictionary.Add("Go", "Wo");
            currentTwoConsonantDictionary.Add("Gw", "Qu");
            currentTwoConsonantDictionary.Add("Gw", "Kw");
            currentTwoConsonantDictionary.Add("Ha", "Ca");
            currentTwoConsonantDictionary.Add("Ha", "Ga");
            currentTwoConsonantDictionary.Add("Ho", "Co");
            currentTwoConsonantDictionary.Add("Ho", "Go");
            currentTwoConsonantDictionary.Add("Hw", "C");
            currentTwoConsonantDictionary.Add("Hw", "K");
            currentTwoConsonantDictionary.Add("Kw", "Hw");
            currentTwoConsonantDictionary.Add("Qu", "Gw");
            currentTwoConsonantDictionary.Add("Th", "Fr");
            currentTwoConsonantDictionary.Add("Th", "T");
            currentTwoConsonantDictionary.Add("Wa", "Ga");
            currentTwoConsonantDictionary.Add("Wh", "B");
            currentTwoConsonantDictionary.Add("Wo", "Go");
            return currentTwoConsonantDictionary;
        }

        public static IDictionary<string, string> OneConsonantDictionary()
        {
            //Total brute force way to do this.
            //This will have to be replaced with a database action
            //to fill a dictionary.
            IDictionary<string, string> currentOneConsonantDictionary = new Dictionary<string, string>();
            currentOneConsonantDictionary.Add("B", "Wh");
            currentOneConsonantDictionary.Add("B", "V");
            currentOneConsonantDictionary.Add("B", "F");
            currentOneConsonantDictionary.Add("B", "P");
            currentOneConsonantDictionary.Add("C", "Hw");
            currentOneConsonantDictionary.Add("C", "G");
            currentOneConsonantDictionary.Add("D", "T");
            currentOneConsonantDictionary.Add("F", "B");
            currentOneConsonantDictionary.Add("F", "P");
            currentOneConsonantDictionary.Add("G", "C");
            currentOneConsonantDictionary.Add("G", "K");
            currentOneConsonantDictionary.Add("H", "K");
            currentOneConsonantDictionary.Add("K", "G");
            currentOneConsonantDictionary.Add("K", "H");
            currentOneConsonantDictionary.Add("K", "Hw");
            currentOneConsonantDictionary.Add("P", "F");
            currentOneConsonantDictionary.Add("P", "B");
            currentOneConsonantDictionary.Add("T", "Th");
            currentOneConsonantDictionary.Add("T", "D");
            currentOneConsonantDictionary.Add("V", "B");
            currentOneConsonantDictionary.Add("V", "W");
            currentOneConsonantDictionary.Add("W", "V");
            return currentOneConsonantDictionary;
        }

        public static IDictionary<string, string> InteriorTwoConsonantDictionary()
        {
            //Total brute force way to do this.
            //This will have to be replaced with a database action
            //to fill a dictionary.
            IDictionary<string, string> InteriorTwoConsonantDictionary = new Dictionary<string, string>();
            InteriorTwoConsonantDictionary.Add("ch", "k");
            InteriorTwoConsonantDictionary.Add("ch", "z");
            InteriorTwoConsonantDictionary.Add("ct", "ht");
            InteriorTwoConsonantDictionary.Add("ff", "v");
            InteriorTwoConsonantDictionary.Add("ft", "pt");
            InteriorTwoConsonantDictionary.Add("ht", "ct");
            InteriorTwoConsonantDictionary.Add("ht", "kt");
            InteriorTwoConsonantDictionary.Add("kt", "ht");
            InteriorTwoConsonantDictionary.Add("pt", "ft");
            InteriorTwoConsonantDictionary.Add("ss", "t");
            InteriorTwoConsonantDictionary.Add("ss", "st");
            InteriorTwoConsonantDictionary.Add("st", "ss");
            InteriorTwoConsonantDictionary.Add("th", "d");

            return InteriorTwoConsonantDictionary;
        }

        public static IDictionary<string, string> InteriorOneConsonantDictionary()
        {
            //Total brute force way to do this.
            //This will have to be replaced with a database action
            //to fill a dictionary.
            IDictionary<string, string> InteriorOneConsonantDictionary = new Dictionary<string, string>();
            InteriorOneConsonantDictionary.Add("b", "v");
            InteriorOneConsonantDictionary.Add("d", "p");
            InteriorOneConsonantDictionary.Add("d", "th");
            InteriorOneConsonantDictionary.Add("d", "t");
            InteriorOneConsonantDictionary.Add("f", "v");
            InteriorOneConsonantDictionary.Add("k", "ch");
            InteriorOneConsonantDictionary.Add("p", "d");
            InteriorOneConsonantDictionary.Add("t", "ss");
            InteriorOneConsonantDictionary.Add("t", "d");
            InteriorOneConsonantDictionary.Add("v", "b");
            InteriorOneConsonantDictionary.Add("v", "f");
            InteriorOneConsonantDictionary.Add("v", "ff");
            InteriorOneConsonantDictionary.Add("z", "ch");

            return InteriorOneConsonantDictionary;
        }
    }
}