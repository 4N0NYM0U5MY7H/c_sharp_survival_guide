using UnityEngine;

namespace Section.Classes.RPG_DB
{
    public class ItemDatabase : MonoBehaviour
    {
        [SerializeField]
        public Item sword;
        public Item hammer;
        public Item bread;

        public Item[] items;

        // Start is called before the first frame update
        void Start()
        {
            sword = new Item();
            sword.name = "Sword";
            sword.id = 1;
            sword.description = "This is a sword";

            hammer = new Item("Hammer", 2, "This is a hammer");

            bread = CreateItem("bread", 2, "I can eat this");

            Debug.Log(items[0].name);
        }

        private Item CreateItem(string name, int id, string description)
        {
            var item = new Item(name, id, description);

            return item;
        }
    }
}