using System.Collections.Generic;
using UnityEngine;

namespace Section.Dictionaries.Looping
{
    public class ItemDB : MonoBehaviour
    {
        public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

        // Start is called before the first frame update
        void Start()
        {
            Item sword = new Item();
            sword.name = "Sword";
            sword.ID = 0;

            Item bread = new Item();
            sword.name = "Bread";
            sword.ID = 1;

            Item cape = new Item();
            sword.name = "Cape";
            sword.ID = 0;

            itemDictionary.Add(0, sword);
            itemDictionary.Add(1, bread);
            itemDictionary.Add(2, cape);

            //foreach (KeyValuePair<int, Item> item in itemDictionary)
            //{
            //    Debug.Log("Key: " + item.Key);
            //    Debug.Log("Value:" + item.Value.name);
            //}

            //foreach (int key in itemDictionary.Keys)
            //{
            //    Debug.Log("Key: " + key);
            //}

            //foreach (Item item in itemDictionary.Values)
            //{
            //    Debug.Log("Item Name: " + item);
            //}

            if (itemDictionary.ContainsKey(60))
            {
                Debug.Log("You found the key!");
                var randomItem = itemDictionary[60];
            }
            else
            {
                Debug.Log("Key does not exist!");
            }
        }
    }
}

