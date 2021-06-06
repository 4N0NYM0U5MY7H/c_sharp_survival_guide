using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingPractical : MonoBehaviour
{
    public GameObject[] cubes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var cube in cubes)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
    }
}
