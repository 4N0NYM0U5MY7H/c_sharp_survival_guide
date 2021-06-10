using UnityEngine;

namespace Section.DesignPatterns.ObjectPooling.Challenge01
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private GameObject _bulletPrefab;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_bulletPrefab); // re-use
            }
        }
    }
}