using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesChallenge_GameManager : MonoBehaviour
{
    /// <summary>
    /// Create properties for the following:
    ///     Speed (read only)
    ///     Name (public)
    /// </summary>

    public float Speed { get; private set; }
    public string Name { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Speed = 10f;
        Debug.Log(Speed);
    }
}
