using UnityEngine;

namespace Section.Arrays
{
    public class PracticalExample_01 : MonoBehaviour
    {
        public GameObject[] cubes;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var cube in cubes)
                {
                    cube.GetComponent<MeshRenderer>().material.color = Color.red;
                }
            }
        }
    }
}