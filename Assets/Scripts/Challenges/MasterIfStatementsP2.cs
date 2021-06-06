using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterIfStatementsP2 : MonoBehaviour
{
    /// <summary>
    /// vairable to store points
    /// if player presses space key
    /// add 10 points
    /// if points greater than or equal to 50
    /// print you are awesome!
    /// </summary>

    [SerializeField]
    private int _points;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }

        if (_points >= 50)
        {
            Debug.Log("You are awesome!");
        }
    }
}
