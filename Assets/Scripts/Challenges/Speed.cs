using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    /// <summary>
    /// Create a program that let's the player increment the speed using the S key
    /// A key decrements the speed
    /// when the speed is greater than 20, print out "Slow down!"
    /// when the speed is 0, print "Speed up!"
    /// speed cannot less than zero
    /// </summary>

    public int speed = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            speed += 5;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            speed -= 5;
        }

        if (speed > 20)
        {
            Debug.Log("Slow Down!");
        }
        else if (speed == 0)
        {
            Debug.Log("Speed Up!");
        }

        if (speed < 0)
        {
            speed = 0;
        }
    }
}
