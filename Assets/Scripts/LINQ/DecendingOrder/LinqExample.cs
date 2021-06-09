using UnityEngine;
using System.Linq;

namespace Section.LINQ.DecendingOrder
{
    public class LinqExample : MonoBehaviour
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