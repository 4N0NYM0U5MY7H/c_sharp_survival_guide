using UnityEngine;

namespace Section.MiscUnity.Rotation.Quaternion_Euler
{
    public class SpawnCube : MonoBehaviour
    {
        [SerializeField]
        private GameObject cubePrefab;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(0, 35, 0));
            }
        }
    }
}