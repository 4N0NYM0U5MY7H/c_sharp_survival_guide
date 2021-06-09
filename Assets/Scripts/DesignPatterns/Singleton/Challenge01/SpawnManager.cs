using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.Singleton.Challenge01
{
    public class SpawnManager : MonoBehaviour
    {
        /// Challenge:
        /// Create the instance (private)
        /// Check if the instance is null
        /// Error handle
        /// Assign the instance (void Awake)
        /// 

        private static SpawnManager _instance;
        public static SpawnManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("SpawnManager is NULL.");

                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }

        public void StartSpawning()
        {
            Debug.Log("Spawn Started");
        }
    }
}