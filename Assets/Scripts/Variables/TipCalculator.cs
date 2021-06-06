using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    /// <summary>
    /// bill is 40
    /// tip is 20% or based on what the user wants
    /// calculate total amount
    /// 
    /// Your bill is: __ and your tip amount is: __ so you owe: totalAmount
    /// </summary>

    public int bill = 40;
    public float tip = 20.0f;
    public float totalAmount;

    // Use this for initialization
    void Start()
    {
        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;

        Debug.Log("Bill: " + bill);
        Debug.Log("Tip: " + tipAmount);
        Debug.Log("Total: " + totalAmount);
    }
}
