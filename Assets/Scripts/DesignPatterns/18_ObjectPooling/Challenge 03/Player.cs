using UnityEngine;

namespace Section.DesignPatterns.ObjectPooling.Challenge03
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
                GameObject bullet = PoolManager.Instance.RequestBullet();
                bullet.transform.position = Vector3.zero;
            }
        }
    }
}