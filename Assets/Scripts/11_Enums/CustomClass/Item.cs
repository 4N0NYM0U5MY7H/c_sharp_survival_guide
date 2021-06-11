using UnityEngine;

namespace Section.Enums.CutomClass
{
    [System.Serializable]
    public class Item
    {
        public string name;
        public int ID;
        public Sprite icon;

        public enum ItemType
        {
            None,
            Weapon,
            Consumable
        }

        public ItemType itemType;

        public void Action()
        {
            switch (itemType)
            {
                case ItemType.Weapon:
                    Debug.Log("This is a " + itemType);
                    break;
                case ItemType.Consumable:
                    Debug.Log("This is a " + itemType);
                    break;
            }
        }
    }
}

