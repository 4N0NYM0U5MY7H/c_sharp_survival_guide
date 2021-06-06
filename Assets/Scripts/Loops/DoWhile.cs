using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile : MonoBehaviour
{
    public int apples;
    int i = 51;

    // Start is called before the first frame update
    void Start()
    {
        do
        {
            // some code
            Debug.Log("My name is Jon");
            apples++;

        } while (apples < 5);

        Debug.Log("Loop 1 has Finished");

        do
        {
            // statement code
            Debug.Log(i);
            
            // index incrementer
            if (i <= 50)
            {
                i++;
            }

        } while (i < 50);

        Debug.Log("Loop 2 has Finished");

    }
}
