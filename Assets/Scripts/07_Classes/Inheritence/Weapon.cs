using UnityEngine;

namespace Section.Classes.Inheritence
{
    [System.Serializable]
    public class Weapon : Item
    {
        public int attackBonus;
        public int prayerBonus;
        public int strengthBonus;
        public int smageBonus;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void MyMethod()
        {
            // inherited/extended class vars are readily accessible
            this.name = "";
            this.id = 1;
            //this.icon = ...;
        }
    }
}