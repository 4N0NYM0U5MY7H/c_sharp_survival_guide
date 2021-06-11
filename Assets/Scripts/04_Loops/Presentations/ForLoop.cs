using System.Collections;
using UnityEngine;

namespace Section.Loops.Presentations
{
    public class ForLoop : MonoBehaviour
    {
        /// Create a program that "increments" the number of apples we have

        public int apples;

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(AddApplesRoutine());
        }

        IEnumerator AddApplesRoutine()
        {
            for (int i = 0; i < 100; i++)
            {
                apples++;
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}