using System;
using UnityEngine;

namespace Section.Delegates_Events.Practice01
{
    public class Main : MonoBehaviour
    {
        /// Creata a delegate of type void that calculates the sum of two numbers
        /// Use a lambda to avoid dedicating a method

        public Action<int, int> Sum;

        // Start is called before the first frame update
        void Start()
        {
            Sum = (a, b) =>
            {
                var total = a + b;

                if (total < 100)
                {
                    Debug.Log("Total is less than 100");
                }

                Debug.Log("Total: " + total);
            };

            Sum(5, 2);
        }
    }
}