using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySyntax : MonoBehaviour
{
    // declare the size (how many elements) through the inspector
    public string[] names;

    public string[] items = new string[5];

    public int[] ages = new int[] { 5, 3, 2, 55, 66 };
}
