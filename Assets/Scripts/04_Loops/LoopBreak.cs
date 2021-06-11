using UnityEngine;

namespace Section.Loops
{
    public class LoopBreak : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            for (int i = 0; i < 100; i++)
            {
                Debug.Log(i);

                if (i == 50)
                {
                    break;
                }
            }

            Debug.Log("Loops has Finished");
        }
    }
}