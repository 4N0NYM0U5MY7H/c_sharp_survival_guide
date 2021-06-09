using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.Singleton.LazyInstantiation
{
    public class SpawnManager : MonoBehaviour
    {
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