using UnityEngine;

namespace Section.Classes.Inheritence.Bank
{
    [System.Serializable]
    public class Bank
    {
        protected string branchName;
        protected string location;
        protected string cashInVault;

        protected void CheckBalance()
        {
            Debug.Log("Checking Balance: " + branchName);
        }

        protected void Withdrawl()
        {
            Debug.Log("Withdrawing Money from: " + branchName);
        }

        protected void Deposit()
        {
            Debug.Log("Deposting Money to: " + branchName);
        }
    }
}