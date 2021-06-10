using UnityEngine;

namespace Section.Variables
{
    public class Variables : MonoBehaviour
    {
        /// public or private references
        /// data type (strings, bools, float, int)
        /// every variable needs a name
        /// optional -- a value
        /// 

        /// variable for name
        /// variable for age
        /// varialbe for location

        public string myName = "Sarah";
        public int myAge = 31;
        public string myLocation = "Luna";
        public bool hasKey = false;

        // Start is called before the first frame update
        void Start()
        {
            myName = "Loren";
            Debug.Log("My name is: " + myName);
            Debug.Log("My age is: " + myAge);
        }
    }
}