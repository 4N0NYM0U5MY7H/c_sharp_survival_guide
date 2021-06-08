using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.EventDrivenProgramming
{
    public class GameManager : MonoBehaviour
    {
        private void OnEnable()
        {
            Player.onDeath += ResetPlayer;
        }

        public void ResetPlayer()
        {
            Debug.Log("Resetting Player");
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}