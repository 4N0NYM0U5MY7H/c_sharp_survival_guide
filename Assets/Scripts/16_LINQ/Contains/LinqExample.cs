using UnityEngine;
using System.Linq;

namespace Section.LINQ.Contains
{
    public class LinqExample : MonoBehaviour
    {
        public string[] names = { "sarah", "kelly", "john", "linda", "catherine", "cortana", "fred" };

        // Start is called before the first frame update
        void Start()
        {
            //var nameFound = names.Any(name => name == "jon");
            
            var nameFound = names.Contains("jon");            
            Debug.Log("Names Found: " + nameFound);
        }
    }
}