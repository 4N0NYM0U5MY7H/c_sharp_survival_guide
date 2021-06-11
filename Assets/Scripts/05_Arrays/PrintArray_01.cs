using UnityEngine;

namespace Section.Arrays.Loops
{
    public class PrintArray_01 : MonoBehaviour
    {
        public int[] itemID;
        public string[] itemName;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                for (int i = 0; i < itemID.Length; i++)
                {
                    Debug.Log(itemID[i]);
                }

                for (int i = 0; i < itemName.Length; i++)
                {
                    Debug.Log(itemName[i]);
                }

                for (int i = 0; i < itemID.Length; i++)
                {
                    if (itemID[i] == 7)
                    {
                        Debug.Log("ItemID: " + itemID[i]);
                        Debug.Log("Item Name: " + itemName[i]);
                    }
                }

                for (int i = 0; i < itemName.Length; i++)
                {
                    if (itemName[i] == "sword")
                    {
                        Debug.Log("Item Exists!");
                        Debug.Log("ItemID: " + itemID[i]);
                    }
                }
            }
        }
    }
}