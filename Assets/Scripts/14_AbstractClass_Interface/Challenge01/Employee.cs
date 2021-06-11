using UnityEngine;

namespace Section.AbstractClass_Interface.Challenge01
{
    /// Challenge Overview:
    ///     create an abstract Employee class that defines the following traits:
    ///     Company Name
    ///     Employee Name
    ///     CalculateMonthlySalary()
    ///
    /// FullTime : Employee
    /// salary
    /// FORCE implement CalculateMonthlySalary()
    /// 
    /// PartTime : Employee
    /// hoursWorked
    /// hourlyRate
    /// FORCE implement CalculateMonthlySlary()

    public abstract class Employee : MonoBehaviour
    {
        public static string company = "UNSC";
        public string employeeName;

        public abstract void CalculateMonthlySalary();
    }
}
