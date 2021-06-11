using UnityEngine;

namespace Section.Classes.Inheritence.Bank
{
    [System.Serializable]
    public class FederalCreditUnion : Bank
    {
        public int availableCashToLend;

        public void ApproveLending()
        {
            Debug.Log("You are awarded a loan!");
        }
    }
}