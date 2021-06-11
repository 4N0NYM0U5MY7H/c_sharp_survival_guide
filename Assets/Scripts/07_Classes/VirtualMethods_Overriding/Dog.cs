using UnityEngine;

namespace Section.Classes.Inheritence.Overriding
{
    public class Dog : Pet
    {
        protected override void Speak()
        {
            Debug.Log("Bark!");
        }
    }
}