using UnityEngine;

namespace Section.Methods
{
    public class Parameters : MonoBehaviour
    {
        public int health;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Damage(5);
            }
        }

        public void Damage(int damageAmount)
        {
            health -= damageAmount;

            if (health < 1)
            {
                health = 0;
                Destroy(this.gameObject);
            }
        }

        void Sum(int a, int b)
        {
            Debug.Log(a + b);
        }

        private void Attack()
        {
            // attack related code
        }

        private void Powerup()
        {
            // powerup related code
        }

        private void Shoot()
        {
            // shoot related code
        }
    }
}