using UnityEngine;

namespace Section.Methods.Challenge01
{
    public class ObjectAsParameter : MonoBehaviour
    {
        /// Challenge Overview:
        /// Create a program that takes an assigned game object from the inspector and pass
        /// that object as a parameter for the method ChangeColor
        /// The parameters for the method are the GameObject and the desired color
        /// All operations should be performed within one method.
        /// 

        public GameObject cube;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeColor(cube, Color.green);
            }
        }

        void ChangeColor(GameObject obj, Color colorToAssign)
        {
            obj.GetComponent<MeshRenderer>().material.color = colorToAssign;
        }
    }
}