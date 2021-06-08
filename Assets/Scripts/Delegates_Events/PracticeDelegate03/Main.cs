using System;
using UnityEngine;

namespace Section.Delegates_Events.PracticeDelegate03
{
    public class Main : MonoBehaviour
    {
        /// Creata a delegate of type int that returns the length of the gameObject's name
        public Func<int> onGetName;

        // Start is called before the first frame update
        void Start()
        {
            onGetName = () => this.gameObject.name.Length;

            int characterCount = onGetName();
            Debug.Log("Character Count: " + characterCount);
        }
    }
}