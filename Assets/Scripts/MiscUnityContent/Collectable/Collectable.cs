using UnityEngine;

namespace Section.MiscUnity.Collectable
{
    public class Collectable : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                // add points
                // add powerup ability

                Destroy(this.gameObject);
            }
        }
    }
}