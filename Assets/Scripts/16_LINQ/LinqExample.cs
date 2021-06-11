using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    public class LinqExample : MonoBehaviour
    {
        public string[] names = { "sarah", "kelly", "john", "linda", "catherine", "cortana", "fred" };

        // Start is called before the first frame update
        void Start()
        {
            //foreach (var name in names)
            //{
            //    if (name == "john")
            //    {
            //        Debug.Log("Found Jon!");
            //    }
            //}

            var nameFound = names.Any(name => name == "john");
            Debug.Log("Names Found: " + nameFound);
        }
    }
}