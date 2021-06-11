using UnityEngine;

namespace Section.AbstractClass_Interface.GenericInterfaces
{
    public class Enemy : MonoBehaviour, IDamagable<GameObject>, IShoot
    {
        public int Health { get; set; }

        public void Damage(GameObject damageAmount)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        public void Shoot()
        {
            throw new System.NotImplementedException();
        }
    }
}