using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    public string branchName;
    public string location;
    public string cashInVault;

    public void CheckBalance()
    {
        Debug.Log("Checking Balance: " + branchName);
    }

    public void Withdrawl()
    {
        Debug.Log("Withdrawing Money from: " + branchName);
    }

    public void Deposit()
    {
        Debug.Log("Deposting Money to: " + branchName);
    }
}
