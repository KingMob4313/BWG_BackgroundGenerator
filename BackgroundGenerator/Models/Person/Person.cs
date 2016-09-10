using System;
using System.Collections;
using System.Collections.Generic;

namespace BackgroundGenerator
{
    public abstract class Person : Race
    {
        public Guid PersonalId;

        public string Title;
        public string GivenName; //Generally assumed as ordinal 1
        public string FamilyName;
        public string NameSuffix;
        public List<OrderedName> OrderedNames;
        public List<Relative> Siblings;
        public List<Relative> Relatives;
        public PersonalTimeline Timeline;

        public Person()
        {
        }

        private static string UppercaseFirst(string strHere)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(strHere))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(strHere[0]) + strHere.Substring(1);
        }

        public string ConsonantSoundShift(string currentName, string startSound, string endSound)
        {
            if (currentName.StartsWith("startSound") && shifted)
            {
                string x = currentName.Substring(0, startSound.Length);
                string y = currentName.Remove(0, x.Length);
                x = x.Replace(startSound, endSound);
                currentName = x + y;
            }

            return currentName;
        }

        public string ShiftConsonantOnce(string currentName)
        {
            //TODO: Create a name shift object
            int intShiftCounter = 0;
            bool blnShifted = false;
            string strFirstVowel = string.Empty;
            int intCombRoll;
            //IntRoll = IntRollTwo = 0;
            Random objRandomGen = new Random();

            int intRoll = objRandomGen.Next(100);
            int intRollTwo = objRandomGen.Next(101);
            intCombRoll = intRoll + intRollTwo;
            bool shifted = false;
            while (!blnShifted)
            {
                intShiftCounter++;
                if (intShiftCounter > 51)
                {
                    //Failure message
                    break;
                }

                if (intCombRoll % 7 == 1 || intCombRoll % 7 == 2 || intCombRoll % 7 == 3 || intCombRoll % 7 == 4)
                {
                    #region Initial Change

                    //Remove initial Vowel and save it
                    if (currentName.StartsWith("A") || currentName.StartsWith("E") || currentName.StartsWith("I") || currentName.StartsWith("O")
                        || currentName.StartsWith("U") || currentName.StartsWith("Y"))
                    {
                        strFirstVowel = currentName.Substring(0, 1).ToString();
                        currentName = UppercaseFirst(currentName.Substring(1));
                    }

                    //Check Quads
                    //Check Trips

                    //Check Dubs

                    foreach (KeyValuePair<string, string> entry in ConsonantLibrary.TwoConsonantDictionary())
                    {
                        currentName = ConsonantSoundShift(currentName, entry.Key.ToString(), entry.Value.ToString());
                    }

                    //Then check sings
                    foreach (KeyValuePair<string, string> entry in ConsonantLibrary.OneConsonantDictionary())
                    {
                        currentName = ConsonantSoundShift(currentName, entry.Key.ToString(), entry.Value.ToString(), shifted);
                    }

                    #endregion Initial Change

                    #region interior changes

                    while (!blnShifted)
                    {
                        string strInitial = string.Empty;
                        string strChanged = string.Empty;
                        int intStartSpot = objRandomGen.Next(currentName.Length - (currentName.Length / 2));
                        foreach (KeyValuePair<string, string> entry in ConsonantLibrary.InteriorTwoConsonantDictionary())
                        {
                            if ((currentName.IndexOf(strInitial, intStartSpot) != -1) && (intCombRoll % 2 == 0) && !blnShifted)
                            {
                                currentName = ChangeLetter(currentName, strInitial, strChanged, intStartSpot, 2);
                                blnShifted = true;
                            }
                        }
                        foreach (KeyValuePair<string, string> entry in ConsonantLibrary.InteriorOneConsonantDictionary())
                        {
                            if ((currentName.IndexOf(strInitial, intStartSpot) != -1) && !shifted)
                            {
                                currentName = ChangeLetter(currentName, strInitial, strChanged, intStartSpot, 2);
                                blnShifted = true;
                            }
                        }
                    }

                    #endregion interior changes
                }
                //All other situations
                else
                {
                }
            }

            return currentName;
        }

        private string ChangeLetter(string strInputText, string strInitial, string strChanged, int intStartSpot, int intChangeLength)
        {
            int y = (strInputText.IndexOf(strInitial, intStartSpot));
            int x = (strInputText.Length - y);
            string strChangedPortion = string.Empty;
            string strChangedPrefix = string.Empty;
            string strChangedSuffix = string.Empty;
            strChangedPortion = strInputText.Substring(y, intChangeLength);
            strChangedPrefix = strInputText.Substring(0, y);
            strChangedSuffix = strInputText.Substring(y + intChangeLength, x - intChangeLength);
            strChangedPortion = strChangedPortion.Replace(strInitial, strChanged);
            strInputText = strChangedPrefix + strChangedPortion + strChangedSuffix;
            return strInputText;
        }
    }
}