using UnityEngine;

namespace Section.Classes.Inheritence
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int id;
        public string description;
        public Sprite icon;

        public Item()
        {
            // default constructor
        }

        public Item(string name, int id, string description)
        {
            this.name = name;
            this.id = id;
            this.description = description;
        }
    }
}
