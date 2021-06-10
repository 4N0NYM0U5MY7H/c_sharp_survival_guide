using UnityEngine;

namespace Section.Variables.Challenge02
{
    public class MasterVariablesP2 : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Provide variables for the following:
        /// 
        ///     name, description, image icon, attack strength
        /// 

        public string itemName;
        public string itemDescription;
        public Sprite itemIcon;
        public float attackStrength;

        // Use this for initialization
        void Start()
        {
            Debug.Log("Name: " + itemName);
            Debug.Log("Description " + itemDescription);
            Debug.Log("Attack: " + attackStrength);
        }
    }
}