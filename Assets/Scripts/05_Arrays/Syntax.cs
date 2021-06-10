using UnityEngine;

namespace Section.Arrays
{
    public class Syntax : MonoBehaviour
    {
        // declare the size (how many elements) through the inspector
        public string[] names;
        
        // initialize size
        public string[] items = new string[5];

        // initialize size and elements
        public int[] ages = new int[] { 5, 3, 2, 55, 66 };
    }
}