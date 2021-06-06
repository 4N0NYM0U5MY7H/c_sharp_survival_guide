using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVariablesP2 : MonoBehaviour
{
    /// <summary>
    /// every item has a name
    /// every item has a description
    /// every item has an image icon
    /// every item has an attack strength
    /// </summary>

    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrength;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description " + itemDescription);
        Debug.Log("Attack: " + attackStrength);
    }
}
