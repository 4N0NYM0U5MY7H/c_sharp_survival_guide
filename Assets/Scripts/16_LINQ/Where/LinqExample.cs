using UnityEngine;
using System.Linq;

namespace Section.LINQ.Where
{
    public class LinqExample : MonoBehaviour
    {
        public string[] names = { "sarah", "kelly", "john", "linda", "catherine", "cortana", "fred" };

        // Start is called before the first frame update
        void Start()
        {
            var result = names.Where(n => n.Length > 5);
            
            foreach (var name in result)
            {
                Debug.Log("Name: " + name);
            }
        }
    }
}