using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    /// <summary>
    /// public or private references
    /// data type (strings, bools, float, int)
    /// every variable needs a name
    /// optional -- a value
    /// </summary>

    // variable for name
    // variable for age
    // varialbe for location

    public string myName = "Jonathan";
    public int myAge = 26;
    public string myLocation = "Atlanta";
    public bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        myName = "Loren";
        Debug.Log("My name is: " + myName);
        Debug.Log("My age is: " + myAge);
    }
}
