using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Section.Lists;

namespace Section.Lists
{
    public class Player : MonoBehaviour
    {
        public Item[] inventory = new Item[10];

        private ItemDB _itemDatabase;

        private void Start()
        {
            _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                // request by id
                _itemDatabase.AddItem(0, this);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                // remove by id
                _itemDatabase.RemoveItem(0, this);
            }
        }
    }
}
