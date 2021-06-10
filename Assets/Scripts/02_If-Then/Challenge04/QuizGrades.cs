using UnityEngine;

namespace Section.IfThen.Challenge04
{
    public class QuizGrades : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create a program that calculates random quiz grades and prints the average
        /// 02: Print the average based on letter grade:
        ///     A = > 90
        ///     B = >= 80 but less than 90
        ///     C = > 70 but less than 80
        ///     F less than 70
        /// 

        public float quiz1, quiz2, quiz3, quiz4, quiz5;

        // Start is called before the first frame update
        void Start()
        {
            quiz1 = Random.Range(0f, 100f);
            quiz2 = Random.Range(0f, 100f);
            quiz3 = Random.Range(0f, 100f);
            quiz4 = Random.Range(0f, 100f);
            quiz5 = Random.Range(0f, 100f);

            float average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

            if (average > 90)
            {
                Debug.Log("You have an A");
            }
            else if (average >= 80 && average < 90)
            {
                Debug.Log("You have a B");
            }
            else if (average >= 70 && average < 80)
            {
                Debug.Log("You have a C");
            }
            else
            {
                Debug.Log("You have an F");
            }
        }
    }
}