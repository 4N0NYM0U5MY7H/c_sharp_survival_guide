using UnityEngine;
using System.Linq;

namespace Section.LINQ
{
    public class LinqExample : MonoBehaviour
    {
        public string[] names = { "jon", "alex", "julie", "jessie", "david", "mark", "matt" };

        // Start is called before the first frame update
        void Start()
        {
            //foreach (var name in names)
            //{
            //    if (name == "jon")
            //    {
            //        Debug.Log("Found Jon!");
            //    }
            //}

            var nameFound = names.Any(name => name == "jon");
            Debug.Log("Names Found: " + nameFound);
        }
    }
}