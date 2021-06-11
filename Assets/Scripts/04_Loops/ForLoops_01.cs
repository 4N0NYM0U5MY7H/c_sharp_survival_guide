using UnityEngine;

namespace Section.Loops
{
    public class ForLoops_01 : MonoBehaviour
    {
        public string playerName = "Sarah";

        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                Debug.Log(playerName);
            }

            Debug.Log("Loop has Finished");
        }
    }
}