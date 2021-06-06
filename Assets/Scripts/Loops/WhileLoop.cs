using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int apples;

    // Start is called before the first frame update
    void Start()
    {
        while (apples < 50)
        {
            Debug.Log(apples);
            apples++;
        }
        Debug.Log("Loop has Finished");

        StartCoroutine(LoopRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawning Enemy Every Second");
        }
    }
}
