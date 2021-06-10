using UnityEngine;

namespace Section.Switch
{
    public class Switch : MonoBehaviour
    {
        public int selectedLevel;

        private int _easy = 0;
        private int _medium = 1;
        private int _hard = 2;

        // Start is called before the first frame update
        void Start()
        {
            selectedLevel = Random.Range(0, 3);
        }

        // Update is called once per frame
        void Update()
        {
            //if (selectedLevel == _easy)
            //{
            //    Debug.Log("You selected Easy!");
            //}
            //else if (selectedLevel == _medium)
            //{
            //    Debug.Log("You selected Medium!");
            //}
            //else if (selectedLevel == _hard)
            //{
            //    Debug.Log("You selected Hard!");
            //}
            //else
            //{
            //    Debug.Log("Invalid Selection!");
            //}

            switch (selectedLevel)
            {
                case 0:
                    Debug.Log("You selected Easy!");
                    break;
                case 1:
                    Debug.Log("You selected Medium!");
                    break;
                case 2:
                    Debug.Log("You selected Hard!");
                    break;
                default:
                    Debug.Log("Invalid Selection!");
                    break;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                selectedLevel = Random.Range(0, 3);
            }
        }
    }
}