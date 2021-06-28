using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Felt.NameGen
{
    public static class NameGenerator
    {
        static List<string> firstNamesMale = new List<string>();
        static List<string> firstNamesFemale = new List<string>();
        static List<string> lastNames = new List<string>();

        public static string GetFirstName(Gender gender)
        {
            if (firstNamesMale.Count == 0)
            {
                LoadLists();
            }

            List<string> listToUse = gender == Gender.Male ? firstNamesMale : firstNamesFemale;

            return listToUse[Random.Range(0, listToUse.Count)].Trim();
        }

        public static string GetLastName()
        {
            return lastNames[Random.Range(0, lastNames.Count)].Trim();
        }

        static void LoadLists()
        {
            string[] list;

            TextAsset ta;

            ta = Resources.Load("Names/firstNamesMale", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            firstNamesMale = list.ToList();

            ta = Resources.Load("Names/firstNamesFemale", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            firstNamesFemale = list.ToList();

            ta = Resources.Load("Names/lastNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            lastNames = list.ToList();
        }
    }


}
