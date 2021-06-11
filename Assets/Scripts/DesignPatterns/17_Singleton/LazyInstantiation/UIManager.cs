using UnityEngine;

namespace Section.DesignPatterns.Singleton.Lazy
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance;
        public static UIManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    GameObject go = new GameObject("UIManager");
                    go.AddComponent<UIManager>();
                }

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