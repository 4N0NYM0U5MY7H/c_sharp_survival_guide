using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.Delegates_Events
{
    public class Sphere : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Main.onClick += Fall;
        }

        public void Fall()
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}