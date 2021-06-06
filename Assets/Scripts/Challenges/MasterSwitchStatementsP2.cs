using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterSwitchStatementsP2 : MonoBehaviour
{
    /// <summary>
    /// Create a program that turns a cube different colors based on user input
    /// 1 key = blue
    /// 2 key = red
    /// 3 key = green
    /// 4 key = black
    /// </summary>

    public GameObject cube;

    private int _nextColor;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _nextColor = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _nextColor = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _nextColor = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _nextColor = 3;
        }

        switch (_nextColor)
        {
            case 0:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;
            default:
                Debug.Log("Invald Selection");
                break;
        }
    }
}
