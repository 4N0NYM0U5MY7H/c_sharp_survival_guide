using UnityEngine;

namespace Section.MiscUnity.UserInput
{
    public class Main : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            // if space key pressed down
            // print a message

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space Key");
            }

            // e key held down
            // print message

            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("Holding E");
            }

            if (Input.GetKeyUp(KeyCode.F))
            {
                Debug.Log("F Key");
            }
        }
    }
}