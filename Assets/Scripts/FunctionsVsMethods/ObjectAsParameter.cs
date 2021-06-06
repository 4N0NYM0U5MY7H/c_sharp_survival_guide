using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAsParameter : MonoBehaviour
{
    /// <summary>
    /// Create a program that takes an assigned game object from the inspector and pass
    /// that object as a parameter for the method ChangeColor
    /// The parameters for the method are the GameObject and the desired color
    /// All operations should be performed within one method.
    /// </summary>

    public GameObject cube;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.green);
        }
    }

    void ChangeColor(GameObject obj, Color colorToAssign)
    {
        obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
    }
}
