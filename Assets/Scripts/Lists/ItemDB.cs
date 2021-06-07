using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Section.Lists;

namespace Section.Lists
{
    public class ItemDB : MonoBehaviour
    {
        public List<Item> itemDatabase = new List<Item>();

        public void AddItem(int itemID, Player _player)
        {
            // check if item matches something in the database
            foreach (var item in itemDatabase)
            {
                // check for match
                if (item.id == itemID)
                {
                    Debug.Log("We have a match!");

                    // check for available inventory slots
                    _player.inventory[0] = item;
                    return;
                }
            }

            Debug.Log("That item does not exist");
        }

        public void RemoveItem(int itemID, Player _player)
        {
            foreach (var item in itemDatabase)
            {
                // check for match
                if (item.id == itemID)
                {
                    Debug.Log("We have a match!");

                    // check for available inventory slots
                    _player.inventory[0] = null; 
                }
            }
        }
    }
}

