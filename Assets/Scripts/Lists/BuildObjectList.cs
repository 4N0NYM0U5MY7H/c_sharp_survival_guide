using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Lists
{
    public class BuildObjectList : MonoBehaviour
    {
        /// Challenge:
        ///     Create a list/array of 3 gameObjects to spawn
        ///     Randomly spawn the elements in a random position between +-10 on the X & Y axis.
        ///     Spawned objects should be tracked in a list called objectsCreated.
        ///     After 10 objects have been spawned
        ///         objects can longer be spawned
        ///         all objects turn GREEN and the list is CLEARED
        /// 

        public GameObject[] SpawnList = new GameObject[3];
        public List<GameObject> objectsCreated = new List<GameObject>();
        public int SpawnCount { get; set; }

        private bool _initColorChange;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (SpawnCount == 10)
                {
                    _initColorChange = true;
                    return;
                }

                var objectToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];
                var maxSpawnDistance = 10f;
                var xRange = Random.Range(-maxSpawnDistance, maxSpawnDistance);
                var yRange = Random.Range(-maxSpawnDistance, maxSpawnDistance);
                var spawnPos = new Vector3(xRange, yRange, 0);

                var spawnedObject = Instantiate(objectToSpawn, spawnPos, Quaternion.identity) as GameObject;

                objectsCreated.Add(spawnedObject);

                SpawnCount++;
            }
 
            if (_initColorChange == true)
            {
                _initColorChange = false;
                
                foreach (var obj in objectsCreated)
                {
                    obj.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                objectsCreated.Clear();
            }
        }
    }
}
