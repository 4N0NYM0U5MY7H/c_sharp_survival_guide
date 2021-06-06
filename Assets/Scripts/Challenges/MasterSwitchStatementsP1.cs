using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSwitchStatementsP1 : MonoBehaviour
{
    /// <summary>
    /// Print a message based on the number of points
    /// 50 points == message
    /// 100 points == message
    /// 0 points == need more points
    /// using switch statements 
    /// </summary> 

    public int points;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            points = 50;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            points = 100;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            points = 0;
        }

        switch (points)
        {
            case 50:
                Debug.Log("Points are 50!");
                break;
            case 100:
                Debug.Log("Points are 100!");
                break;
            default:
                Debug.Log("You need 50 or 100 points to recieve a message");
                break;
        }
    }
}
