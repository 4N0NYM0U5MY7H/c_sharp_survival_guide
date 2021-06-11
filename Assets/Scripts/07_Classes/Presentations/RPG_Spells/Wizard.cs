using UnityEngine;

namespace Section.Classes.RPG_Spells
{
    public class Wizard : MonoBehaviour
    {
        public Spell fireBall;
        public Spell[] spells;
        public int level = 1;
        public int exp;

        private void Start()
        {
            fireBall = new Spell("Fire Ball", 1, 17, 35);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                fireBall.Cast();
                exp += fireBall.expGained;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var spell in spells)
                {
                    if (spell.levelRequired == level)
                    {
                        spell.Cast();
                        exp += spell.expGained;
                    }
                }
            }
        }
    }
}