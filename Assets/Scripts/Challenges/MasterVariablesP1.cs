using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVariablesP1 : MonoBehaviour
{
    /// <summary>
    /// reate a variable to store player name
    /// create a variable to store player age
    /// create a variable to store player speed
    /// create a health variable
    /// create a score variable
    /// create a speed variable
    /// variable to check if all keys were collected
    /// variable for ammo count
    /// </summary>

    public string playerName = "Jonathan";
    public int playerAge = 26;
    public float speed = 10.2f;
    public int health = 100;
    public int score = 120;
    public bool hasAllKeys;
    public int ammoCount = 66;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player name: " + playerName);
        Debug.Log("Player age: " + playerAge);
        Debug.Log("Health: " + health);
        Debug.Log("Speed: " + speed);
        Debug.Log("Ammo Count: " + ammoCount);
        Debug.Log("Has All Keys? " + hasAllKeys);
    }
}
