using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterIfStatementsP1 : MonoBehaviour
{
    /// <summary>
    /// vairable to store points
    /// if player presses space key
    /// add 10 points
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
    }
}
