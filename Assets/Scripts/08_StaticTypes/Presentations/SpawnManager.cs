using UnityEngine;

namespace Section.Static.Presentations
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject enemyPrefab;

        public static int enemyCount;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(enemyPrefab);
            }
        }
    }
}