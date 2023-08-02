using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    /// This class shows how to use the Contains method in LINQ.
    /// Contains method returns true if the collection contains the specified element.
    /// Returns true on the first element that satisfies the condition.
    public class LinqContains : MonoBehaviour
    {
        public string[] names = { "sarah", "kelly", "john", "linda", "catherine", "cortana", "fred" };

        // Start is called before the first frame update
        void Start()
        {   
            // This is similar to using the Any method.
            // var nameFound = names.Any(name => name == "john");
            
            var nameFound = names.Contains("john");            
            Debug.Log("Names Found: " + nameFound);
        }
    }
}