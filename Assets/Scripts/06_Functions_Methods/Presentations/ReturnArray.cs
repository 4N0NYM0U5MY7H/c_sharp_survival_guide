using UnityEngine;

namespace Section.Methods.Presentations
{
    public class ReturnArray : MonoBehaviour
    {
        public GameObject[] players;

        // Start is called before the first frame update
        void Start()
        {
            players = GetAllPlayers();
        }

        GameObject[] GetAllPlayers()
        {
            GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

            foreach (var p in allPlayers)
            {
                p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
            }

            return allPlayers;
        }
    }
}