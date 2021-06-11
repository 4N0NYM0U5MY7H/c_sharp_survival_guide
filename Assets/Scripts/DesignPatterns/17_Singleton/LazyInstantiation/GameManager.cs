using UnityEngine;

namespace Section.DesignPatterns.Singleton.Lazy
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("The GameManager is NULL.");

                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }

        public void DisplayName()
        {
            Debug.Log("My name is Unknown");
        }
    }
}