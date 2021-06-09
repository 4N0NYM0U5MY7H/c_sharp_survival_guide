using UnityEngine;
using System.Linq;

namespace Section.LINQ.Distinct
{
    public class LinqExample : MonoBehaviour
    {
        public string[] names = { "jon", "jon", "alex", "julie", "alex", "julie", "jessie", "david", "mark", "matt" };

        // Start is called before the first frame update
        void Start()
        {
            var uniqueNames = names.Distinct();

            foreach (var name in uniqueNames)
            {
                Debug.Log("Name: " + name);
            }
        }
    }
}