using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHelper_Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ColorHelper_Methods.ChangeColor(this.gameObject, Color.red);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ColorHelper_Methods.ChangeColor(this.gameObject, Color.red, true);
        }
    }
}
