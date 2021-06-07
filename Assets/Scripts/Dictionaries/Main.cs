using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Dictionaries.PlayerConnections
{
    public class Player
    {
        public string name;
        public int ID;

        public Player(int id)
        {
            this.ID = id;
        }
    }

    public class Main : MonoBehaviour
    {
        public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();

        // Start is called before the first frame update
        void Start()
        {
            Player p1 = new Player(1);
            p1.name = "Jimmy";
            Player p2 = new Player(200);
            p2.name = "Kyle";
            Player p3 = new Player(9);
            p3.name = "Yin";

            playerDictionary.Add(p1.ID, p1);
            playerDictionary.Add(p2.ID, p2);
            playerDictionary.Add(p3.ID, p3);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var player = playerDictionary[200];
                Debug.Log("Player name: " + player.name);
            }
        }
    }
}

