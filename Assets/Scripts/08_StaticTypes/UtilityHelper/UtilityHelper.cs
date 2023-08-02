using UnityEngine;

namespace Section.Static.Utility
{
    public static class UtilityHelper
    {
        public static void CreateGameObject()
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        }

        public static void SetPositionToZero(GameObject obj)
        {
            obj.transform.position = Vector3.zero;
        }
    }
}