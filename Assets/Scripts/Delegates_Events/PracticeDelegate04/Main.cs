using System;
using UnityEngine;

namespace Section.Delegates_Events.PracticeDelegate04
{
    public class Main : MonoBehaviour
    {
        /// Creata a delegate of type int that returns the sum of 2 numbers
        public Func<int, int, int> onCalculateSum;

        // Start is called before the first frame update
        void Start()
        {
            onCalculateSum = (a, b) =>
            {
                a = 7;
                Debug.Log("More code here");
                return a + b;
            };

            var total = onCalculateSum(5, 5);
            Debug.Log("Total: " + total);
        }
    }
}