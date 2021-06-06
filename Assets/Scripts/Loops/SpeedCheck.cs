using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedCheck : MonoBehaviour
{
    /// <summary>
    /// Create a program that meets the following:
    ///     increment the value of speed every second
    ///     when speed is greater than MaxSpeed
    ///         stop incrementing (Random between 60 and 120)
    /// </summary>

    public int speed;
    public int maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = Random.Range(60, 120);
        StartCoroutine(SpeedRoutine());
    }

    IEnumerator SpeedRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            speed += 5;

            if (speed > maxSpeed)
            {
                break;
            }
        }

        /*
        do
        {
            speed += 5;
            yield return new WaitForSeconds(0.5f);

        } while (speed > maxSpeed);*/
    }
}
