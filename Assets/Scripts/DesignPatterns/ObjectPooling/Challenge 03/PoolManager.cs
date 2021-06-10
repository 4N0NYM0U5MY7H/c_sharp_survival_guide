using System.Collections.Generic;
using UnityEngine;

namespace Section.DesignPatterns.ObjectPooling.Challenge03
{
    public class PoolManager : MonoBehaviour
    {
        /// Challenge:
        /// Recycle the bullet game object.
        ///     

        private static PoolManager _instance;
        public static PoolManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("PoolManager is NULL.");

                return _instance;
            }
        }

        [SerializeField]
        private GameObject _bulletContainer;
        [SerializeField]
        private GameObject _bulletPrefab;
        [SerializeField]
        private List<GameObject> _bulletPool;

        private void Awake()
        {
            _instance = this;
        }

        private void Start()
        {
            _bulletPool = GenerateBullets(10);
        }

        List<GameObject> GenerateBullets(int amountOfBullets)
        {
            for (int i = 0; i < amountOfBullets; i++)
            {
                GameObject bullet = Instantiate(_bulletPrefab);
                bullet.transform.parent = _bulletContainer.transform;
                bullet.SetActive(false);
                _bulletPool.Add(bullet);
            }

            return _bulletPool;
        }

        public GameObject RequestBullet()
        {
            /// loop through the bullet list
            foreach(var bullet in _bulletPool)
            {
                if (bullet.activeInHierarchy == false)
                {
                    // bullet is available
                    bullet.SetActive(true);
                    return bullet;
                }
            }

            // need to create a new bullet
            GameObject newBullet = Instantiate(_bulletPrefab);
            newBullet.transform.parent = _bulletContainer.transform;
            _bulletPool.Add(newBullet);

            return newBullet;
        }
    }
}