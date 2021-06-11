using UnityEngine;

namespace Section.Properties.Auto
{
    public class GameManager : MonoBehaviour
    {
        public bool IsGameOver { get; protected set; }

        // Start is called before the first frame update
        void Start()
        {
            IsGameOver = false;

            if (IsGameOver)
            {

            }

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsGameOver = true;
            }
        }
    }
}