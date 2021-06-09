using UnityEngine;
using System.Linq;

namespace Section.LINQ.DecendingOrder
{
    public class LinqExample : MonoBehaviour
    {
        /// Challenge:
        /// Create a program where you have an integer array of quiz grades.
        /// The quiz grades should be between 0-100.
        /// Filter through the quiz grades and create a new collection of only passing grades (above 69)
        /// 

        public int[] quizGrades = { 44, 55, 32, 77, 95, 98, 99 };

        // Start is called before the first frame update
        void Start()
        {
            var passingGrades = quizGrades.Where(qg => qg > 69).OrderByDescending(g => g).Reverse();

            foreach (var grade in passingGrades)
            {
                Debug.Log("Grade: " + grade);
            }
        }
    }
}