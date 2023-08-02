using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    /// This class shows how to use the Where method in LINQ.
    /// Where method returns a collection of elements that satisfy the condition.
    /// Returns all elements that satisfy the condition.
    public class LinqWhere : MonoBehaviour
    {
        public string[] names = { "sarah", "kelly", "john", "linda", "catherine", "cortana", "fred" };

        // Start is called before the first frame update
        void Start()
        {
            /// Filter the names that have more than 5 characters.
            var result = names.Where(n => n.Length > 5);
            
            foreach (var name in result)
            {
                Debug.Log("Name: " + name);
            }
        }
    }
}