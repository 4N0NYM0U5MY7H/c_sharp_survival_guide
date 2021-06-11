using UnityEngine;

namespace Section.Delegates_Events.Challenge01
{
    public class Main : MonoBehaviour
    {
        /// Challenge:
        /// Create a program using delegates and events:
        ///     On key press, assign a Cube the postion of (5, 2, 0)
        ///     The Cube script should subsribe to the event and be invoked on key press
        ///     

        public delegate void Teleport(Vector3 pos);
        public static event Teleport onTeleport;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (onTeleport != null)
                {
                    Vector3 pos = new Vector3(5, 2, 0);
                    onTeleport(pos);
                }
            }
        }
    }
}