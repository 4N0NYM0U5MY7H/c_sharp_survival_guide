using UnityEngine;

namespace Section.AbstractClass_Interface.Polymorphism
{
    public class Player : MonoBehaviour, IDamagable
    {
        public int Health { get; set; }

        public void Damage(int damageAmount)
        {
            Health -= damageAmount;
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}