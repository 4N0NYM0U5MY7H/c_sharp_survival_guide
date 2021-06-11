using UnityEngine;

namespace Section.Classes.Custom
{
    public class Powerup : MonoBehaviour
    {
        WeaponStats blasters;

        // Start is called before the first frame update
        void Start()
        {
            // Asign a weapon to player upon collection
            blasters = new WeaponStats("Blasters", 0.25f, 50);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            UIManager.Instance.UpdateWeaponStats(blasters);
            Destroy(this.gameObject);
        }
    }
}