using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorHelper_Methods
{
    /// <summary>
    /// create a helper class that passes an object as a parameter and changes the color.
    ///
    /// player can activate with the space key
    ///
    /// Bonus: randomize the color
    /// </summary> 

    public static void ChangeColor(GameObject obj, Color color, bool randomColor = false)
    {
        if (randomColor == true)
        {
            color = new Color(Random.value, Random.value, Random.value);
        }
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}
