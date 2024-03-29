﻿using UnityEngine;

namespace Section.Variables.Challenge04
{
    public class QuizCalculator : MonoBehaviour
    {
        /// Challenge Overview:
        /// 
        /// 01: Create program that calculates random quiz grades and prints the average
        ///     of five quiz grades
        /// 

        public float quiz1, quiz2, quiz3, quiz4, quiz5;

        // Use this for initialization
        void Start()
        {
            quiz1 = Random.Range(0f, 100f);
            quiz2 = Random.Range(0f, 100f);
            quiz3 = Random.Range(0f, 100f);
            quiz4 = Random.Range(0f, 100f);
            quiz5 = Random.Range(0f, 100f);

            float average = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;

            average = Mathf.Round(average * 100f) / 100f;

            Debug.Log("Average Quiz Score: " + average);
        }
    }
}