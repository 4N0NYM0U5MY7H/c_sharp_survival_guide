using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.AbstractClass_Interface.Interface
{
    public interface IDamagable
    {
        int Health { get; set; }

        void Damage(int damageAmount);
    }
}