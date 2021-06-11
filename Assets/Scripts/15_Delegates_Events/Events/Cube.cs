using UnityEngine;

namespace Section.Delegates_Events.Events
{
    public class Cube : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Main.onClick += TurnRed;
        }

        public void TurnRed()
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

        private void OnDisable()
        {
            Main.onClick -= TurnRed;
        }
    }
}