using System;
using UnityEngine;

namespace Section.Delegates_Events.Lambda
{
    public class Main : MonoBehaviour
    {
        // Create a program that takes in a string and returns the length

        //public delegate int CharacterLength(string text);        
        //CharacterLength cl;

        public Func<string, int> CharacterLength;

        // Start is called before the first frame update
        void Start()
        {
            // Return type function
            int characterCount = GetCharacters("Jonathan");
            Debug.Log("Character Count: " + characterCount);

            //CharacterLength charLen = new CharacterLength(GetCharacters);
            //Debug.Log(cl("Jon"));

            CharacterLength = GetCharacters;
            int count = CharacterLength("Jessica");
            Debug.Log("Count: " + count);
        }

        int GetCharacters(string name)
        {
            return name.Length;
        }
    }
}