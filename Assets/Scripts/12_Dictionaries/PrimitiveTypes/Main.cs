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
            people.Add("Sarah", 31);
            people.Add("Kelly", 47);
            people.Add("John", 47);
            people.Add("Linda", 47);

            int lindasAge = people["Linda"];
            Debug.Log("Linda's Age: " + lindasAge);

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