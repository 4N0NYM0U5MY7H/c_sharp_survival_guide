using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Enums 
{
    public class SelectDifficulty : MonoBehaviour
    {
        public enum LevelSelector
        {
            Easy, // 0
            Normal, // 1
            Hard, // 2
            Expert // 3
        }

        public LevelSelector currentLevel;

        // Start is called before the first frame update
        void Start()
        {
            switch (currentLevel)
            {
                case LevelSelector.Easy:
                    Debug.Log("Easy Difficulty");
                    break;
                case LevelSelector.Normal:
                    Debug.Log("Normal Difficulty");
                    break;
                case LevelSelector.Hard:
                    Debug.Log("Hard Difficulty");
                    break;
                case LevelSelector.Expert:
                    Debug.Log("Expert Difficulty");
                    break;
                default:
                    Debug.Log("Something Broke!");
                    break;
            }
        }
    }
}
