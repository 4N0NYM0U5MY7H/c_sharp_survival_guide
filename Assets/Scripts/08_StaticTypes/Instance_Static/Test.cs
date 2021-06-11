using UnityEngine;

namespace Section.Static.Instance_Static
{
    public class Item
    {
        public string name;
        public int itemID;
        public static int itemCount;

        public Item()
        {
            itemCount++;
        }
    }

    public class Player
    {
        public int id;
        public string name;
        public static int connectionCount;

        public Player()
        {
            connectionCount++;
        }
    }

    public class Test : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Item sword = new Item();
            Item bread = new Item();
            Item cape = new Item();
            Item fish = new Item();

            Debug.Log("Item Count: " + Item.itemCount);

            Player p1 = new Player();
            Player p2 = new Player();
            Player p3 = new Player();
            Player p4 = new Player();

            Debug.Log("Players on server: " + Player.connectionCount);
        }
    }
}

