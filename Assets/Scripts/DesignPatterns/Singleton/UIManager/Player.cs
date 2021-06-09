using UnityEngine;

namespace Section.DesignPatterns.Singleton.UIManger
{
    public class Player : MonoBehaviour
    {
        // Traditional method
        //private UIManager _ui;

        // Start is called before the first frame update
        void Start()
        {
            // Traditoinal method
            //_ui = GameObject.Find("UIManager").GetComponent<UIManager>();
            //_ui.UpdateScore(40);

            UIManager.Instance.UpdateScore(40);
        }
    }
}