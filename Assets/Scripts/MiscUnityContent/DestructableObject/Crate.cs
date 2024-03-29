﻿using UnityEngine;

namespace Section.MiscUnity.Destructable
{
    public class Crate : MonoBehaviour
    {
        public GameObject fracturedCrate;
        public GameObject explostionEffect;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(explostionEffect, transform.position, Quaternion.identity);

                GameObject fracturedCrateObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity);
                Rigidbody[] allRigidBodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>();

                if (allRigidBodies.Length > 0)
                {
                    foreach (var body in allRigidBodies)
                    {
                        body.AddExplosionForce(500, transform.position, 1);
                    }
                }

                Destroy(this.gameObject);
            }
        }
    }
}