using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.Actions
{
    public class Player : MonoBehaviour
    {
        //public delegate void OnDamageRecieved(int currentHealth);
        //public static event OnDamageRecieved onDamage;

        //public delegate void onComplete();
        //public Action onComplete;

        public static Action<int> OnDamagedRecieved;

        public  int Health { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            Health = 10;
        }

        void Damage()
        {
            Health--;
            //if (onDamage != null)
            //{
            //    onDamage(Health);
            //}
            if (OnDamagedRecieved != null)
            {
                OnDamagedRecieved(Health);
            }
        }
    }
}