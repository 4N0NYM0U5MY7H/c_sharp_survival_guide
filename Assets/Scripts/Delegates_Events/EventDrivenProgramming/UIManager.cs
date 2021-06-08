using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Section.Delegates_Events.EventDrivenProgramming
{
    public class UIManager : MonoBehaviour
    {
        public int deathCount;
        public Text deathCountText;

        public void OnEnable()
        {
            Player.onDeath += UpdateDeathCount;
        }

        public void UpdateDeathCount()
        {
            deathCount++;
            deathCountText.text = "Death Count: " + deathCount;
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}