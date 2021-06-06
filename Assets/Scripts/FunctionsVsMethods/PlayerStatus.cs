using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    /// <summary>
    /// Create a program that checks whether the player is dead or alive.
    /// On space key press, damage the player by a random amount.
    /// If the player is dead, print "The player has died!"
    /// 
    /// Bonus: Prevent the method from being called if the player is dead
    ///        (no negative health values)
    /// </summary>

    public int health = 100;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            Damage(Random.Range(5, 20));
        }
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (IsDead())
        {
            health = 0;
            Debug.Log("The player has died!");
        }
    }

    public bool IsDead()
    {
        return health < 1;
    }
}
