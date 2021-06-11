using UnityEngine;

namespace Section.Classes.Inheritence.Overriding
{
    public class Duck : Pet
    {
        protected override void Speak()
        {
            Debug.Log("Quack Quack");
        }
    }
}