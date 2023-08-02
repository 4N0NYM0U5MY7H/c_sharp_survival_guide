using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    /// This class shows how to use the Any method in LINQ.
    /// Any method returns true if any element in the collection satisfies the condition.
    /// Returns true on the first element that satisfies the condition.
    public class LinqAny : MonoBehaviour
    {
        public string[] names = { "sarah", "kelly", "john", "linda", "catherine", "cortana", "fred" };

        // Start is called before the first frame update
        void Start()
        {
            // The same result can be achieved using a foreach loop.
            //
            // foreach (var name in names)
            // {
            //    if (name == "john")
            //    {
            //        Debug.Log("Found John!");
            //    }
            // }

            var nameFound = names.Any(name => name == "john");
            Debug.Log("Names Found: " + nameFound);
        }
    }
}