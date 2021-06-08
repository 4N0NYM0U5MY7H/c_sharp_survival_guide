using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.AbstractClass_Interface.Interface
{
    public class Player : MonoBehaviour, IDamagable, IShoot
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            Health -= damageAmount;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}