using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Dictionaries
{
    public class ItemDB : MonoBehaviour
    {
        public List<Item> itemList = new List<Item>();
        public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

        // Start is called before the first frame update
        void Start()
        {
            Item sword = new Item();
            sword.name = "Sword";
            sword.ID = 0;

            itemList.Add(sword);
            itemDictionary.Add(0, sword);

            var item = itemDictionary[0];
            // item.ID
            // item.name
        }
    }
}

