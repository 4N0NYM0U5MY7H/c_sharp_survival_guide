using UnityEngine;

namespace Section.DesignPatterns.Singleton
{
    public class Player : MonoBehaviour
    {
        // Traditional method
        //private GameManager _gm;

        // Start is called before the first frame update
        void Start()
        {
            // Traditoinal method
            //_gm = GameObject.Find("GameManager").GetComponent<GameManager>();

            GameManager.Instance.DisplayName();
        }
    }
}