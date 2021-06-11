using UnityEngine;

namespace Section.Delegates_Events.Actions
{
    public class UIManager : MonoBehaviour
    {
        public void OnEnable()
        {
            //Player.onDamage += UpdateHealth;
            Player.OnDamagedRecieved += UpdateHealth;
        }
        public void UpdateHealth(int health)
        {
            Debug.Log("Current Health: " + health);
        }
    }
}