using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterIfStatementsP4 : MonoBehaviour
{
    /// <summary>
    /// Create a program that when the player presses the space key, the score value is incremented.
    /// When the score value is greater than 50, the cube turns Green.
    /// At the start of the program, set the cube color to red.
    /// 
    /// </summary>
 
    public GameObject cube;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && score <= 50)
        {
            score += 25;
        }
        
        if (score > 50)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
