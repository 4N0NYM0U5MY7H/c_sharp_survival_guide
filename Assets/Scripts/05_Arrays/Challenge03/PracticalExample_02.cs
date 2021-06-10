using UnityEngine;

namespace Section.Arrays.Challenge03
{
    public class PracticalExample_02 : MonoBehaviour
    {
        /// Challenge Overview:
        /// Convert the program from a foreach loop to a for loop
        /// 

        public GameObject[] cubes;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                foreach (var cube in cubes)
                {
                    cube.GetComponent<MeshRenderer>().material.color = Color.red;
                }
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                for (int i = 0; i < cubes.Length; i++)
                {
                    cubes[i].GetComponent<MeshRenderer>().material.color = Color.green;

                }
            }
        }
    }
}