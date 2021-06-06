using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimatePrintOut : MonoBehaviour
{
    /// <summary>
    /// Create a loop that meets the following conditions:
    ///     prints 0-10
    ///     prints even numbers up to 20
    ///     prints odd numbers up to 30
    /// </summary>

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            if (i < 10)
            {
                Debug.Log(i);
            }

            if (i > 9 && i < 21)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
            else if (i > 20)
            {
                Debug.Log(i);
            }
        }
    }
}
