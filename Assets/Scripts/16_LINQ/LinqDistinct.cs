using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    /// This class shows how to use the Distinct method in LINQ.
    /// Distinct method returns a collection of unique elements.
    /// Excludes duplicates.
    public class LinqDistinct : MonoBehaviour
    {
        public string[] names = { "sarah", "sarah", "kelly", "john", "linda", "linda", "catherine", "cortana", "fred", "fred" };

        // Start is called before the first frame update
        void Start()
        {
            /// Set the array to only contain unique names (no duplicates).
            var uniqueNames = names.Distinct();

            foreach (var name in uniqueNames)
            {
                Debug.Log("Name: " + name);
            }
        }
    }
}