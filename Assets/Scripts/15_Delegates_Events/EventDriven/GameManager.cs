using UnityEngine;

namespace Section.Delegates_Events.EventDriven
{
    public class GameManager : MonoBehaviour
    {
        private void OnEnable()
        {
            Player.onDeath += ResetPlayer;
        }

        public void ResetPlayer()
        {
            Debug.Log("Resetting Player");
        }
    }
}