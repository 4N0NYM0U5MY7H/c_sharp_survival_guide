using UnityEngine;

namespace Section.Properties.Challenge01
{
    public class GameManager : MonoBehaviour
    {
        /// Challenge Overview:
        /// Create properties for the following:
        ///     Speed (read only)
        ///     Name (public)
        /// 

        public float Speed { get; private set; }
        public string Name { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            Speed = 10f;
            Debug.Log(Speed);
        }
    }
}