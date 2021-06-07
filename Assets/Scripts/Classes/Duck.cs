using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : Pet
{
    protected override void Speak()
    {
        Debug.Log("Quack Quack");
    }
}
