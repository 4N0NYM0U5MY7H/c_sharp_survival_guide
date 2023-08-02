using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    public class QuerySyntax : MonoBehaviour
    {
        // Specify the data source.
        int[] scores = new int[] { 97, 92, 81, 60 };

        // Start is called before the first frame update
        void Start()
        {
            // Define the query expression.
            var scoreQuerySyntax =
                from score in scores
                where score > 80
                select score;

            var scoreQuere = scores.Where(score => score > 80);

            foreach (var score in scoreQuerySyntax)
            {
                Debug.Log("Score: " + score);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
