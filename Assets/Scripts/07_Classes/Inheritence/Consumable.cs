using UnityEngine;

namespace Section.Classes.Inheritence
{
    [System.Serializable]
    public class Consumable : Item
    {
        // consumables: foods (added health) 
        // class inherits/extends from Item class

        public int addedHealth;
        public bool isPoison;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}