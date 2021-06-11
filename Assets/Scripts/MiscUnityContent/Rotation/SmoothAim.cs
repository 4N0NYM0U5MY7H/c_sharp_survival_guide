using UnityEngine;

namespace Section.MiscUnity.Rotation.QuaternionSlerp
{
    public class SmoothAim : MonoBehaviour
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
            Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);
        }
    }
}