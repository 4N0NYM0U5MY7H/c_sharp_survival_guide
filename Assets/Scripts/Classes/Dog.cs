using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    protected override void Speak()
    {
        Debug.Log("Bark!");
    }
}
