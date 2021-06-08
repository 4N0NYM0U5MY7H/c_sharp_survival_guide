using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.Challenge01
{
    public class Cube : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Main.onTeleport += Spawn;
        }

        public void Spawn(Vector3 pos)
        {
            transform.position = pos;
        }

        private void OnDisable()
        {
            Main.onTeleport -= Spawn;
        }
    }
}