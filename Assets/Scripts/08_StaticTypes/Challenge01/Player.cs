using UnityEngine;

namespace Section.Static.Challenge01
{
    public class Player : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ColorHelper.ChangeColor(this.gameObject, Color.red);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ColorHelper.ChangeColor(this.gameObject, Color.red, true);
            }
        }
    }
}