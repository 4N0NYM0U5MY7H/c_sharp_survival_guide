using UnityEngine;

namespace Section.MiscUnity.ObjectPosition
{
    public class Player : MonoBehaviour
    {
        public Vector3 startPostion;

        // Start is called before the first frame update
        void Start()
        {
            // grab current pos = (assign) new position
            transform.position = new Vector3(0, 0, 0);
        }
    }
}