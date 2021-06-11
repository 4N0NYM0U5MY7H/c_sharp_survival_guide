using System.Collections.Generic;
using UnityEngine;

namespace Section.Lists.Challenge01
{
    public class GameManager : MonoBehaviour
    {
        /// Challenge Overview:
        /// Create a list of names and print each.
        /// On key press:
        ///     remove" a random element from the list
        ///     re-print the remaining names
        /// 

        public List<string> names = new List<string>();

        // Start is called before the first frame update
        void Start()
        {
            foreach (var name in names)
            {
                Debug.Log(name);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                var nameToRemove = names[Random.Range(0, names.Count)];
                names.Remove(nameToRemove);

                foreach (var name in names)
                {
                    Debug.Log(name);
                }

                Debug.Log("We removed " + nameToRemove);
            }
        }
    }
}
