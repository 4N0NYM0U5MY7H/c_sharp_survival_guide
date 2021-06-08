using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.Delgates
{
    public class Main : MonoBehaviour
    {
        public delegate void ChangeColor(Color newColor);
        public ChangeColor onColorChange;

        public delegate void OnComplete();
        public OnComplete onComplete;

        // Start is called before the first frame update
        void Start()
        {
            onColorChange = UpdateColor;
            onColorChange(Color.green);

            // signitures must match
            // onColorChange = Task;
            
            onComplete += Task;
            onComplete += Task2;
            onComplete += Task3;

            onComplete -= Task3;

            if (onComplete != null)
            {
                onComplete();
            }
        }

        public void UpdateColor(Color newColor)
        {
            Debug.Log("Changing color to: " + newColor.ToString());
        }

        public void Task()
        {
            Debug.Log("Task 1 Finished");
        }

        public void Task2()
        {
            Debug.Log("Task 2 Finished");
        }

        public void Task3()
        {
            Debug.Log("Task 3 Finished");
        }
    }
}