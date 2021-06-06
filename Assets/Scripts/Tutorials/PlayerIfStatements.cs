using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIfStatements : MonoBehaviour
{
    public int age = 26;
    private int _legalAgeToDrive = 16;

    // Start is called before the first frame update
    void Start()
    {
        // if age is greater than or euqal to 16 (legal age to drive)
        // then print you can drive
        // else
        // print you can't drive

        if (age >= _legalAgeToDrive)
        {
            Debug.Log("You can drive!");
        }
        else
        {
            Debug.Log("You can't drive!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
