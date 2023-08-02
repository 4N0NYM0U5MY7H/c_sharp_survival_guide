using UnityEngine;

namespace Section.Static.Utility
{
    public class Player : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UtilityHelper.CreateGameObject();
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                UtilityHelper.SetPositionToZero(this.gameObject);
            }
        }
    }
}