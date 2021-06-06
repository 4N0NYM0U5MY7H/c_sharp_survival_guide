using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsP2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            // only print evens
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("Loop 1 has Finished");

        for (int i = 0; i < 100; i++)
        {
            // only print odds
            if (i % 2 == 1)
            {
                Debug.Log(i);
            }
        }

        Debug.Log("Loop 2 has Finished");

        for (int i = 0; i < 100; i++)
        {
            // only print 76
            if (i == 76)
            {
                Debug.Log("i = " + i);
            }
        }

        Debug.Log("Loop 3 has Finished");

    }
}
