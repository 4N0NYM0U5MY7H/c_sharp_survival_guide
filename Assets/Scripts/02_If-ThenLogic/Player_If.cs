using UnityEngine;

namespace Section.IfThen
{
    public class Player_If : MonoBehaviour
    {
        public int age = 31;
        private int _legalAgeToDrive = 16;

        // Start is called before the first frame update
        void Start()
        {
            // if age is greater than or euqal to 16 (legal age to drive)
            // then print you can drive
            // else
            // print you can't drive

            if (age >= _legalAgeToDrive)
            {
                Debug.Log("You can drive!");
            }
            else
            {
                Debug.Log("You can't drive!");
            }
        }
    }
}