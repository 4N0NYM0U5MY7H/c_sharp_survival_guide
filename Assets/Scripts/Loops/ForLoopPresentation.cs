using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopPresentation : MonoBehaviour
{
    /// <summary>
    /// create a program that "increments" the number of apples we have
    /// </summary>

    public int apples;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AddApplesRoutine());
    }

    IEnumerator AddApplesRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(0.5f);
        }
    }
}
