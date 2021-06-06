using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSelection : MonoBehaviour
{
    /// <summary>
    /// Create an array of 5 names
    /// Create an array of 5 ages that correspond to each name
    /// Create an array of 5 cars associates with each name
    /// 
    ///     Randomly select a name and print all related details
    /// 
    /// Bonus: Handle print with the space key
    /// </summary>

    public string[] names;
    public int[] ages;
    public string[] cars;

    public int randomID;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomID = Random.Range(0, names.Length);
            Debug.Log(randomID);
            Debug.Log("Name: " + names[randomID] + " Age: " + ages[randomID] + " Vehicle: " + cars[randomID]);
        }
    }
}
