using UnityEngine;

namespace Section.Classes.Custom
{
    public class WeaponStats
    {
        public string name;
        public float fireRate;
        public int ammoCount;

        public WeaponStats()
        {
            // Initialize things here
            name = "Blasters";
            fireRate = 0.25f;
            ammoCount = 50;
        }

        public WeaponStats(string name, float fireRate, int ammoCount)
        {
            this.name = name;
            this.fireRate = fireRate;
            this.ammoCount = ammoCount;
        }
    }

    public class Player : MonoBehaviour
    {
        public GameObject laserPrefab;
        public Transform firePos;

        [SerializeField]
        private float _speed;

        private WeaponStats blasters;
        private WeaponStats lasers;
        private WeaponStats rockets;

        // Use this for initialization
        private void Start()
        {
            blasters = new WeaponStats();
            lasers = new WeaponStats("Lasers", 1.0f, 100);

            rockets = new WeaponStats();
            rockets.name = "Rockets";
            rockets.fireRate = 5.0f;
            rockets.ammoCount = 1;

            Debug.Log("Current Weapon Name: " + blasters.name);
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