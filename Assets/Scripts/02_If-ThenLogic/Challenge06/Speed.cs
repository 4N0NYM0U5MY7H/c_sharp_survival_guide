using UnityEngine;

namespace Section.IfThen.Challenge06
{
    public class Speed : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create a program that increments or decrements on key press (S, A)
        /// 02: When speed is greater than 20
        ///         print slow down
        ///     When speed is 0
        ///         print speed up
        ///     
        /// Note: speed must be greater than 0
        /// 

        public int speed = 0;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                speed += 5;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                speed -= 5;
            }

            if (speed > 20)
            {
                Debug.Log("Slow Down!");
            }
            else if (speed == 0)
            {
                Debug.Log("Speed Up!");
            }

            if (speed < 0)
            {
                speed = 0;
            }
        }
    }
}