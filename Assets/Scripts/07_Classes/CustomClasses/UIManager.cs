using UnityEngine;
using UnityEngine.UI;

namespace Section.Classes.Custom
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance;
        public static UIManager Instance
        {
            get
            {
                if (_instance == null)
                    Debug.LogError("The UIManager is NULL.");

                return _instance;
            }
        }

        private void Awake()
        {
            _instance = this;
        }

        public Text name, fireRate, ammoCount;

        public void UpdateWeaponStats(WeaponStats weapon)
        {
            name.text += weapon.name;
            fireRate.text += weapon.fireRate;
            ammoCount.text += weapon.ammoCount;
        }
    }
}
