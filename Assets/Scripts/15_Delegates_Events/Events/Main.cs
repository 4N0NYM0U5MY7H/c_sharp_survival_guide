﻿using UnityEngine;

namespace Section.Delegates_Events.Events
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