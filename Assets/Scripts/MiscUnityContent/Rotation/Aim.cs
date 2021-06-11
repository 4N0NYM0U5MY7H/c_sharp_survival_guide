using UnityEngine;

namespace Section.MiscUnity.Rotation.Look_Rotation
{
    public class Aim : MonoBehaviour
    {
        [SerializeField]
        private Transform _sphere; // target sphere

        // Update is called once per frame
        void Update()
        {
            // dicrection = destination - source
            Vector3 directionToFace = _sphere.position - transform.position;
            Debug.DrawRay(transform.position, directionToFace, Color.green);

            // access current location = Quaternion Look rotation
            transform.rotation = Quaternion.LookRotation(directionToFace);
        }
    }
}