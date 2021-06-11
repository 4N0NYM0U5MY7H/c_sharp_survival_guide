using UnityEngine;

namespace Section.Classes.Challenge01
{
    [System.Serializable]
    public class Customer : MonoBehaviour
    {
        public string firstName;
        public string lastName;
        public int age;
        public string gender;
        public string occupation;

        public Customer(string first, string last, int age, string gender, string occupation)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = age;
            this.gender = gender;
            this.occupation = occupation;
        }
    }
}