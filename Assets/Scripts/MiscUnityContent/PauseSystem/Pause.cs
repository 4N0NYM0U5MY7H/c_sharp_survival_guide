using UnityEngine;

namespace Section.MiscUnity.Pause
{
    public class Pause : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 0;
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                Time.timeScale = 1;
            }
        }
    }
}