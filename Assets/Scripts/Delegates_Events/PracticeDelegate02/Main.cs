using System;
using UnityEngine;

namespace Section.Delegates_Events.PracticeDelegate02
{
    public class Main : MonoBehaviour
    {
        /// Creata a delegate of type void that has no parameter and returns the gameObject's name
        public Action onGetName;

        // Start is called before the first frame update
        void Start()
        {
            onGetName = () => 
            {
                Debug.Log("Name: " + gameObject.name);
                Debug.Log("It's a nice day out!");
            };

            // code
            // code

            onGetName();
        }
    }
}