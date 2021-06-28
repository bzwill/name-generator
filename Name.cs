using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace Felt.NameGen
{    
    public class Name
    {        
        public string First { get; private set; }

        public string Middle { get; private set; }        

        public string Last { get; private set; }

        public string Nick { get; private set; }

        public string LastNameBeforeMarriage { get; private set; }

        public string FirstAndLast
        {
            get
            {
                return string.Format(First + " " + Last);
            }
        }

        public string Full
        {
            get
            {
                return string.Format(First + " " + Middle + " " + Last);
            }
        }

        public string FirstAndLastWithNickName
        {
            get
            {
                return string.Format(First + " \"" + Nick + "\" " + Last);
            }
        }

        public Name(Gender gender)
        {
            First = NameGenerator.GetFirstName(gender);
            Middle = NameGenerator.GetFirstName(gender);
            Last = NameGenerator.GetLastName();
            LastNameBeforeMarriage = Last;
        }

        public void SetFirstName(string name)
        {
            First = name;
        }

        public void SetMiddleName(string name)
        {
            Middle = name;
        }

        public void SetLastName(string name)
        {
            Last = name;
        }

        public void SetNickName(string nickName)
        {
            Nick = nickName;
        }

        public void SetMaritalLastName(string lastName)
        {
            Last = lastName;
        }
    }
}