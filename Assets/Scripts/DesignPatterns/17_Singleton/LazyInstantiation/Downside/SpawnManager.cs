using UnityEngine;

namespace Section.DesignPatterns.Singleton.Lazy.Downside
{
    public class SpawnManager : MonoBehaviour
    {
        private static SpawnManager _instance;
        public static SpawnManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject("SpawnManager");
                    go.AddComponent<SpawnManager>();
                }

                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }

        [SerializeField]
        private GameObject _enemyPrefab;

        public void StartSpawning()
        {
            Debug.Log("Spawn Started");
            Instantiate(_enemyPrefab);
        }
    }
}