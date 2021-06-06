using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMaster : MonoBehaviour
{
    /// <summary>
    /// Create an array of 5 names and print out the last name
    /// Create an array of 5 ages that correspond to each name; print the last age
    /// Create an array of 5 car makes; associate with each name; print the last car
    /// 
    /// Bonus: Handle print with the space key
    /// </summary>

    public string[] names;
    public int[] ages;
    public string[] cars;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Name: " + names[4] + " Age: " + ages[4] + " Vehicle: " + cars[4]);
        }

    }
}
