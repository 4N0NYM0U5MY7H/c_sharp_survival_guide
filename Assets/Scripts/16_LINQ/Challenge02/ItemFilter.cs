using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Section.LINQ.Challenge02
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int itemID;
        public int buff;
    }

    public class ItemFilter : MonoBehaviour
    {
        /// Challenge:
        /// Check if itemID 3 exists in the list and print out true or false.
        /// Grab all items with buff greater than 20 and print them out.
        /// Calculate the average of all the buff stats.
        /// 

        public List<Item> items;

        // Start is called before the first frame update
        void Start()
        {
            var itemExists = items.Any(item => item.itemID == 3);
            Debug.Log("ItemID 3 Exists: " + itemExists);

            var itemBuff = items.Where(item => item.buff > 20);
            foreach (var item in itemBuff)
            {
                Debug.Log("Item with Buff greater than 20: " + item.name);
            }

            var buffAvg = items.Average(item => item.buff);
            Debug.Log("Buff Average: " + buffAvg);
        }
    }
}