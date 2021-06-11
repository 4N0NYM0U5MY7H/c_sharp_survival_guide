using UnityEngine;

namespace Section.Static.Constructor
{
    public class Employee
    {
        public int employeeID;
        public string first, last;
        public int salary;

        public static string company;

        // this constructor will be called subsequently for each Employee object
        public Employee()
        {
            Debug.Log("Initialized Instance Members");
        }

        // this will be called first, only once
        static Employee()
        {
            company = "UNSC";
            Debug.Log("Initialized Static Members");
        }
    }

    public class StaticConstructor : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Employee e1 = new Employee();
            var e2 = new Employee();
            var e3 = new Employee();
            var e4 = new Employee();
            Employee e5 = new Employee();
        }
    }
}