using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    /// This class shows how to use the OrderByDescending method in LINQ.
    /// Returns a collection of elements in descending order.
    public class LinqDescending : MonoBehaviour
    {
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