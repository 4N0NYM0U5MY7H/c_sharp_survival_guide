using UnityEngine;

namespace Section.Classes.Custom
{
    public class Laser : MonoBehaviour
    {
        [SerializeField]
        private float _speed = 10f;

        // Update is called once per frame
        void Update()
        {
            Movement();
        }

        void Movement()
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);

            if (transform.position.y > 30)
            {
                Destroy(this.gameObject);
            }
        }
    }
}