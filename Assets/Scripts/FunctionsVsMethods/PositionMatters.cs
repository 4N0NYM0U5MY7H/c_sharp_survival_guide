using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMatters : MonoBehaviour
{
    /// <summary>
    /// Create an array of 5 positions.
    /// Use a method to generate a random index
    /// Use a method to set the position of that index
    /// </summary>

    public Vector3[] positions;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = GetPostion(GetRandom());
    }

    int GetRandom()
    {
        return Random.Range(0, positions.Length);
    }

    Vector3 GetPostion(int index)
    {
        return positions[index];
    }
}
