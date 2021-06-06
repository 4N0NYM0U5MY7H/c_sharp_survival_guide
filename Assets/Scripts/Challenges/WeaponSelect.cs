using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelect : MonoBehaviour
{
    /// <summary>
    /// id 1 = Gun
    /// id 2 = Knife
    /// id 3 = Machine Gun
    /// </summary>

    public int WeaponID;

    // Update is called once per frame
    void Update()
    {
        switch (WeaponID)
        {
            case 1:
                Debug.Log("Gun equipped");
                break;
            case 2:
                Debug.Log("Knife equipped");
                break;
            case 3:
                Debug.Log("Machine Gun equipped");
                break;
            default:
                Debug.Log("You can't equip that");
                break;
        }
    }
}
