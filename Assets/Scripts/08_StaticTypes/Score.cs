using UnityEngine;

namespace Section.Static
{
    // static classes cannot inherit
    // public static class Score { }

    public class Score : MonoBehaviour
    {
        // non-static implementation:
        //public int score;

        // static implementation:
        // note: static variables are not visible in the inspector
        public static int score;

        // static method
        public static void AddScore()
        {
            // do stuff
        }
    }
}