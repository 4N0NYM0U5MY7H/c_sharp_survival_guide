using UnityEngine;

namespace Section.Classes.Inheritence.Overriding
{
    public class Pet : MonoBehaviour
    {
        protected string petName;

        protected virtual void Speak()
        {
            Debug.Log("Speak!");
        }

        private void Start()
        {
            Speak();
        }
    }
}