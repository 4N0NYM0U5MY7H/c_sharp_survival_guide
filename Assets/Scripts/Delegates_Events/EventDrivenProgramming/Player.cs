using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.EventDrivenProgramming
{
    public class Player : MonoBehaviour
    {
        public delegate void OnDeath();
        public static event OnDeath onDeath;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Death();
            }
        }

        void Death()
        {
            if (onDeath != null)
            {
                onDeath();
            }

            //GameObject.FindObjectOfType<GameManager>().ResetPlayer();
            //GameObject.FindObjectOfType<UIManager>().UpdateDeathCount();
        }
    }
}