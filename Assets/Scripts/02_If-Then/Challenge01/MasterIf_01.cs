using UnityEngine;

namespace Section.IfThen.Challenge01
{
    public class MasterIf_01 : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create a vairable to store points
        /// 02: if player presses space key
        ///         add 10 points
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
        }
    }
}