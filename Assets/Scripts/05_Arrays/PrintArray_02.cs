using UnityEngine;

namespace Section.Arrays.Loops
{
    public class PrintArray_02 : MonoBehaviour
    {
        public string[] itemNames;
        public int[] agesArray;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //for (int i = 0; i < itemName.Length; i++)
                //{
                //    Debug.Log(itemName[i]);
                //}

                foreach (var item in itemNames)
                {
                    Debug.Log(item);
                }

                foreach (var item in itemNames)
                {
                    if (item == "sword")
                    {
                        Debug.Log(item);
                    }
                }

                foreach (var age in agesArray)
                {
                    Debug.Log(age);
                }
            }
        }
    }
}