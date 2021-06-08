using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.AbstractClass_Interface.GenericInterfaces
{
    public class Player : MonoBehaviour, IDamagable<int>
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}