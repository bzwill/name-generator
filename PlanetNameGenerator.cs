using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Felt.NameGen
{
    public static class PlanetNameGenerator
    {
        static List<string> names = new List<string>();

        public static string GetName()
        {
            if (names.Count == 0)
            {
                LoadLists();
            }
            
            return names[Random.Range(0, names.Count)].Trim();
        }

        static void LoadLists()
        {
            string[] list;

            TextAsset ta;

            ta = Resources.Load("Names/planetNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            names = list.ToList();            
        }
    }
}