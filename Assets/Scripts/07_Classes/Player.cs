using UnityEngine;

namespace Section.Classes
{
    public class Player : MonoBehaviour
    {
        public GameObject laserPrefab;
        public Transform firePos;

        [SerializeField]
        private float _speed;

        // Use this for initialization
        private void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            CalculateMovement();
            FireProjectile();
        }

        private void CalculateMovement()
        {
            float hInput = Input.GetAxis("Horizontal");
            float vInput = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(hInput, vInput, 0) * _speed * Time.deltaTime);

            PlayerBounds();
        }

        private void PlayerBounds()
        {
            if (transform.position.x > 8.5f)
            {
                transform.position = new Vector3(8.5f, transform.position.y, 0);
            }
            else if (transform.position.x < -8.5f)
            {
                transform.position = new Vector3(-8.5f, transform.position.y, 0);
            }

            if (transform.position.y > 8)
            {
                transform.position = new Vector3(transform.position.x, 8, 0);
            }
            else if (transform.position.y < -8)
            {
                transform.position = new Vector3(transform.position.x, -8, 0);
            }
        }

        void FireProjectile()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(laserPrefab, firePos.position, Quaternion.identity);
            }
        }
    }
}