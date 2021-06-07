using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.AbstractClass_Interface.Challenge01
{
    /// Challenge:
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
        public static string company = "GameDevHQ";
        public string employeeName;

        public abstract void CalculateMonthlySalary();
    }
}
