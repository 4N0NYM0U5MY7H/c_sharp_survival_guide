using UnityEngine;

namespace Section.IfThen.Challenge05
{
    public class MasterIf_04 : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create a program that when the player presses the space key
        ///     the score value is incremented.
        /// 02: When the score value is greater than 50
        ///     the cube turns Green.
        /// 
        /// Note: At the start of the program, set the cube color to red.
        /// 

        public GameObject cube;
        public int score = 0;

        // Start is called before the first frame update
        void Start()
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && score <= 50)
            {
                score += 25;
            }

            if (score > 50)
            {
                cube.GetComponent<Renderer>().material.color = Color.green;
            }
        }
    }
}