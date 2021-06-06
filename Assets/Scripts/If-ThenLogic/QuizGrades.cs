using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGrades : MonoBehaviour
{
    /// <summary>
    /// 5 quiz grades
    /// calculate the average quiz grades
    /// print out the average based on the following:
    ///     print A = > 90
    ///     print B = >= 80 but less than 90
    ///     print C = > 70 but less than 80
    ///     print F less than 70
    /// </summary>

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
