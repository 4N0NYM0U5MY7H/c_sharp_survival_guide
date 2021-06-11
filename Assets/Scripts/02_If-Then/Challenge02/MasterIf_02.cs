using UnityEngine;

namespace Section.IfThen.Challenge02
{
    public class MasterIf_02 : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create a vairable to store points
        /// 02: if player presses space key
        ///         add 10 points
        /// 
        /// 03: if points greater than or equal to 50
        ///     print you are awesome!
        /// 

        [SerializeField]
        private int _points;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _points += 10;
            }

            if (_points >= 50)
            {
                Debug.Log("You are awesome!");
            }
        }
    }
}