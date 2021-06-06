using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakLoop : MonoBehaviour
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
