using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Section.Delegates_Events.Delegates_Events
{
    public class Main : MonoBehaviour
    {
        public delegate void ActionClick();
        public static event ActionClick onClick;

        public void ButtonClick()
        {
            if (onClick != null)
                onClick();
        }
    }
}