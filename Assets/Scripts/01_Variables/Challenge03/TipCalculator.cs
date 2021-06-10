using UnityEngine;

namespace Section.Variables.Challenge03
{
    public class TipCalculator : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Use the following data:
        /// 
        ///     bill of $40
        ///     tip is 20% or User input
        ///     Calculate total
        /// 
        /// 02: Print message to user:
        /// 
        ///     Your bill is:__ and you tip amount is:__  Total due:__
        ///

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
}