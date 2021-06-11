using UnityEngine;

namespace Section.AbstractClass_Interface.Polymorphism
{
    public class Main : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(rayOrigin, out hitInfo))
                {
                    IDamagable obj = hitInfo.collider.GetComponent<IDamagable>();

                    if (obj != null)
                    {
                        obj.Damage(500);
                    }
                }
            }
        }
    }
}