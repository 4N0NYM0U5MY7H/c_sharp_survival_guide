using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Lists 
{
    public class GameManager : MonoBehaviour
    {
        public List<GameObject> enemiesToSpawn = new List<GameObject>();
        public GameObject[] objectsToSpawn = new GameObject[10];

        void Start()
        {
            objectsToSpawn[0] = new GameObject();

            // enemiesToSpawn.Add(new GameObject);
        }
    }
}

