using UnityEngine;

namespace Section.DesignPatterns.ObjectPooling
{
    public class Bullet : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Destroy(this.gameObject, 1f);
        }
    }
}