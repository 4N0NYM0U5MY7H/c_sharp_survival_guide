using UnityEngine;

namespace Section.Static
{
    public class Test : MonoBehaviour
    {
        // static implementation
        // access class variable directly

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Score.score += 10;

                Debug.Log("Current Score: " + Score.score);

                // non-static
                // _score.score += 10;
            }
        }

        // non-static implementation
        // requires an instance of a class to access
        //private Score _score;

        //// Start is called before the first frame update
        //void Start()
        //{
        //    _score = GameObject.Find("Score Keeper").GetComponent<Score>();
        //}
    }
}