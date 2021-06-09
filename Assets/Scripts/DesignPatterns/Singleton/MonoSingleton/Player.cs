using UnityEngine;

namespace Section.DesignPatterns.Singleton.Mono
{
    public class Player : MonoSingleton<Player>
    {
        public string name;

        public override void Init()
        {
            base.Init();
            Debug.Log("Player Initialized!");
            LevelManager.Instance.LoadLevel();
        }
    }
}