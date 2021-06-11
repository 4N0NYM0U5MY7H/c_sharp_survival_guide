using UnityEngine;

namespace Section.Classes.Inheritence
{
    public class ItemDatabase : MonoBehaviour
    {
        [SerializeField]
        public Item goldCoin = new Item();
        [SerializeField]
        public Weapon sword = new Weapon();
        [SerializeField]
        public Consumable bread = new Consumable();

        // Start is called before the first frame update
        void Start()
        {

        }
    }
}