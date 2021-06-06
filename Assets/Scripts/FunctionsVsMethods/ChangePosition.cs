using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GoToPosition1();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GoToPosition2(new Vector3(2, 2, 2));
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.position = GetPosition(3, 3, 3);
        }
    }

    public void GoToPosition1()
    {
        transform.position = Vector3.one;
    }

    public void GoToPosition2(Vector3 pos)
    {
        transform.position = pos;
    }

    public Vector3 GetPosition(float x, float y, float z)
    {
        Vector3 pos = new Vector3(x, y, z);
        
        return pos;
    }
}
