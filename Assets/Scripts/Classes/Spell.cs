using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell
{
    public string name;
    public int levelRequired;
    public int itemIdRequired;
    public int expGained;

    public Spell(string name, int levRequired, int itemIdRequired, int exp)
    {
        this.name = name;
        this.levelRequired = levRequired;
        this.itemIdRequired = itemIdRequired;
        this.expGained = exp;
    }

    public void Cast()
    {
        Debug.Log("Casting: " + this.name);
    }
}
