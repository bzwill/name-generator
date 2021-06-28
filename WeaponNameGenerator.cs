using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Felt.NameGen
{
    public static class WeaponNameGenerator
    {
        static List<string> shotgunNames = new List<string>();
        static List<string> rifleNames = new List<string>();
        static List<string> SMGNames = new List<string>();

        static List<string> godNames = new List<string>();
        static List<string> prefixNames = new List<string>();

        public static string GetName(WeaponModelClass weaponClass)
        {
            if (shotgunNames.Count == 0)
            {
                LoadLists();
            }

            string name = "";
            
            name += " ";

            if(weaponClass == WeaponModelClass.ShotGun)
            {
                name += shotgunNames.RandomElement().Trim();
            }
            if (weaponClass == WeaponModelClass.SMG)
            {
                name += SMGNames.RandomElement().Trim();
            }
            if (weaponClass == WeaponModelClass.Rifle)
            {
                name += rifleNames.RandomElement().Trim();
            }

            name += " ";
            name += prefixNames.RandomElement().Trim();

            return name;
        }

        static void LoadLists()
        {
            string[] list;

            TextAsset ta;

            ta = Resources.Load("Names/shotgunNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            shotgunNames = list.ToList();
            ta = Resources.Load("Names/rifleNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            rifleNames = list.ToList();
            ta = Resources.Load("Names/SMGNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            SMGNames = list.ToList();

            ta = Resources.Load("Names/godNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            godNames = list.ToList();
            ta = Resources.Load("Names/prefixNames", typeof(TextAsset)) as TextAsset;
            list = ta.text.Split('\n');
            prefixNames = list.ToList();
        }
    }
}