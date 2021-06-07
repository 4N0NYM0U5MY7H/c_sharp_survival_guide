using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Dictionaries.PrimitiveTypes
{
    public class Main : MonoBehaviour
    {
        public Dictionary<string, int> people = new Dictionary<string, int>();
        public Dictionary<int, string> books = new Dictionary<int, string>();


        // Start is called before the first frame update
        void Start()
        {
            people.Add("Jon", 36);
            people.Add("Jame", 55);
            people.Add("Rachel", 31);
            people.Add("Yin", 34);

            int rachelsAge = people["Rachel"];
            Debug.Log("Rachel's Age: " + rachelsAge);

            books.Add(0, "The Ultimate Guide to Game Development with Unity");
            books.Add(1, "The Unity C# Survival Guide");

            Debug.Log(books[1]);

            //foreach (KeyValuePair<int, string> book in books)
            //{
            //    Debug.Log("Book: " + book.Value);
            //}

            foreach (string book in books.Values)
            {
                Debug.Log("Book: " + book);
            }
        }
    }
}

