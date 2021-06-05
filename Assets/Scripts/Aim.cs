using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _sphere;

    // Update is called once per frame
    void Update()
    {
        // dicrection = destination - source
        Vector3 directionToFace = _sphere.position - transform.position;
        Debug.DrawRay(transform.position, directionToFace, Color.green);

        // access current location = Quaternion Look rotation
        transform.rotation = Quaternion.LookRotation(directionToFace);
    }
}
