using UnityEngine;

namespace Section.Arrays.Presentations
{
    [System.Serializable]
    public class Item
    {
        public int itemID;
        public string name;
        public string description;
    }

    public class ArrayLooping : MonoBehaviour
    {
        public Item[] myItems;

        // Start is called before the first frame update
        void Start()
        {
            foreach (var item in myItems)
            {
                Debug.Log(item.name);
            }

            // check for id 7
            foreach (var item in myItems)
            {
                if (item.itemID == 7)
                {
                    Debug.Log("You have this item");
                }
                else
                {
                    Debug.Log("You do not have this item");
                }
            }

            // check for id 7
            for (int i = 0; i < myItems.Length; i++)
            {
                if (myItems[i].itemID == 7)
                {
                    Debug.Log("You have this item");
                }
                else
                {
                    Debug.Log("You do not have this item");
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                int randomID = Random.Range(0, myItems.Length);

                Debug.Log(myItems[randomID].name);
            }
        }
    }
}