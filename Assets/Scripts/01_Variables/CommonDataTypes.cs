using UnityEngine;

namespace Section.Variables
{
    public class CommonDataTypes : MonoBehaviour
    {
        public int score;
        public float speed = 5.5f;

        public GameObject player;
        public Animator anim;
        public Transform myTransform;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(myTransform.position.x);
        }
    }
}