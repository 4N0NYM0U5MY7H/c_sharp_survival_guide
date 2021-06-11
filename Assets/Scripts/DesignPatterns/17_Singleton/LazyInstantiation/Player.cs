using UnityEngine;

namespace Section.DesignPatterns.Singleton.Lazy
{
    public class Player : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            SpawnManager.Instance.StartSpawning();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UIManager.Instance.UpdateScore(40);
            }
        }
    }
}