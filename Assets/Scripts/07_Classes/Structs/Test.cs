using UnityEngine;

namespace Section.Classes.Structs
{
    public struct Item2  // VALUE TYPE -- Stack
    {
        public string name;
        public int itemID;

        public Item2(string name, int itemID)
        {
            this.name = name;
            this.itemID = itemID;
        }
    }

    public class Item  // REFERENCE TYPE -- Heap
    {
        public string name;
        public int itemID;

        public Item(string name, int itemID)
        {
            this.name = name;
            this.itemID = itemID;
        }
    }

    public class Test : MonoBehaviour
    {
        Item sword;

        Item hammer = new Item("Hammer", 2);
        Item2 bread;

        private void Start()
        {
            sword = new Item("Sword", 1);

            bread.name = "Bread";
            bread.itemID = 3;

            Debug.Log("Class: Reference Type");
            Debug.Log("Weapon to upgrade: " + hammer.name);
            ChangeValue(hammer);
            Debug.Log("Upgraded weapon: " + hammer.name);

            Debug.Log("Struct: Value Type");
            Debug.Log("Food to upgrade: " + bread.name);
            ChangeValue(bread);
            Debug.Log("Upgraded food: " + bread.name);


            // Notes for later

            int age = 31; // value type

            // move value types
            // bool, bytes, char, doubles, float, int, long, structs

            string myName = "Sarah"; // reference type

            // more reference types
            // strings, arrays, delegates
        }

        void ChangeValue(Item2 structItem) // value type
        {
            structItem.name = "Bread Loaf";
        }

        void ChangeValue(Item classItem) // reference type
        {
            classItem.name = "War Hammer";
        }
    }
}
