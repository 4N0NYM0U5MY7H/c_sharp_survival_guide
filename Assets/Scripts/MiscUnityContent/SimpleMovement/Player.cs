using UnityEngine;

namespace Section.MiscUnity.SimpleMovement
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private float _speed;

        // Update is called once per frame
        void Update()
        {
            //             new Vector3(1, 0, 0) * 5 * real time
            float horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
        }
    }
}