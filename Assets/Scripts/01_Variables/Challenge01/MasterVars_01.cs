using UnityEngine;

namespace Section.Variables.Challenge01
{
    public class MasterVars_01 : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create a variable for the following:
        /// 
        ///     name, age, speed, health, score,
        ///     check if keys collected, ammo count
        /// 
        /// 02: Print all to console
        /// 

        public string playerName = "User";
        public int playerAge = 31;
        public float speed = 10.2f;
        public int health = 100;
        public int score = 120;
        public bool hasAllKeys;
        public int ammoCount = 316;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("Player name: " + playerName);
            Debug.Log("Player age: " + playerAge);
            Debug.Log("Health: " + health);
            Debug.Log("Speed: " + speed);
            Debug.Log("Ammo Count: " + ammoCount);
            Debug.Log("Has All Keys? " + hasAllKeys);
        }
    }
}