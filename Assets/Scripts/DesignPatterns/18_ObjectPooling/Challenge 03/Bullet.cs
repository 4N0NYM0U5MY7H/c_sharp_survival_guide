using UnityEngine;

namespace Section.DesignPatterns.ObjectPooling.Challenge03
{
    public class Bullet : MonoBehaviour
    {
        private void OnEnable()
        {
            Invoke("Hide", 1);
        }

        void Hide()
        {
            this.gameObject.SetActive(false);
        }
    }
}