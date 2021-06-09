using UnityEngine;

namespace Section.DesignPatterns.Singleton.UIManger
{
    public class UIManager : MonoBehaviour
    {
        // private variable to delcare the instance of this class. -- has to be static
        private static UIManager _instance;
        public static UIManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("UIManager is NULL.");

                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }

        public void UpdateScore(int score)
        {
            Debug.Log("Score: " + score);
            Debug.Log("Notifying GameManager");
            GameManager.Instance.DisplayName();
        }
    }
}