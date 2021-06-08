using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.AbstractClass_Interface.Polymorphism
{
    public class Enemy : MonoBehaviour, IDamagable, IShoot
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            Health -= damageAmount;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}