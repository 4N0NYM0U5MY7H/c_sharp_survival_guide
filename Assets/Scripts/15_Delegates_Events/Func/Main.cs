using System;
using UnityEngine;

namespace Section.Delegates_Events.Func
{
    public class Main : MonoBehaviour
    {
        // Create a program that takes in a string and returns the length
        //public delegate int CharacterLength(string text);        

        public Func<string, int> CharacterLength;

        // Start is called before the first frame update
        void Start()
        {
            CharacterLength = (name) => name.Length;
            int count = CharacterLength("Jessica");
            Debug.Log("Count: " + count);
        }

        //int GetCharacters(string name)
        //{
        //    return name.Length;
        //}
    }
}