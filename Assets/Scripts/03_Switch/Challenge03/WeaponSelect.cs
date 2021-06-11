using UnityEngine;

namespace Section.Switch.Challenge03
{
    public class WeaponSelect : MonoBehaviour
    {
        /// Challenge Overview:
        /// Create a program with switch statement to swap weapons and inform the user based on key press
        ///     (1 : gun, 2 : knife, 3 : machine gun)

        public int WeaponID;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                WeaponID = 0;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                WeaponID = 1;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                WeaponID = 2;
            }

            switch (WeaponID)
            {
                case 1:
                    Debug.Log("Gun equipped");
                    break;
                case 2:
                    Debug.Log("Knife equipped");
                    break;
                case 3:
                    Debug.Log("Machine Gun equipped");
                    break;
                default:
                    Debug.Log("You can't equip that");
                    break;
            }
        }
    }
}