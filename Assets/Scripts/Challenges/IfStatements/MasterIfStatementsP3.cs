using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterIfStatementsP3 : MonoBehaviour
{
    /// <summary>
    /// variable to store points
    /// hasSaidMessage variable
    /// if player presses space key
    /// add 10 points
    /// if points greater than or equal to 50 AND hasSaidMessage is false
    /// print you are awesome!
    /// </summary>

    [SerializeField]
    private int _points;

    private bool _hasMessageBeenSent = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _points += 10;
        }

        if (_points >= 50 && _hasMessageBeenSent == false)
        {
            Debug.Log("You are awesome!");
            _hasMessageBeenSent = true;
        }
    }
}
