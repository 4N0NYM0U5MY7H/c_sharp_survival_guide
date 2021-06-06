using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseIfStatements : MonoBehaviour
{
    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    // Start is called before the first frame update
    void Start()
    {
        currentDifficulty = mediumDifficulty;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDifficulty == easyDifficulty)
        {
            Debug.Log("You selected easy");
        }
        else if (currentDifficulty == mediumDifficulty)
        {
            Debug.Log("You selected medium");
        }
        else if (currentDifficulty == hardDifficulty)
        {
            Debug.Log("You selected hard");
        }
        else
        {
            Debug.Log("Invalid difficulty");
        }
    }
}
