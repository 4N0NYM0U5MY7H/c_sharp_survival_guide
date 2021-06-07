using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.AbstractClass_Interface.Challenge01
{
    public class FullTime : Employee
    {
        public int salary;

        public override void CalculateMonthlySalary()
        {
            throw new System.NotImplementedException();
        }
    }
}