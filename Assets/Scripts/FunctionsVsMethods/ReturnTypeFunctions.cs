using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnTypeFunctions : MonoBehaviour
{
    public int total;

    // Start is called before the first frame update
    void Start()
    {
        Sum(5, 2);
        Add(10, 2);
    }

    private void  Sum(int a, int b)
    {
        Debug.Log(a + b);

        total = a + b;
    }

    private int Add(int a, int b)
    {
        return a + b;
    }
}
