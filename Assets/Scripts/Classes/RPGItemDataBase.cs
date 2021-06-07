using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGItemDataBase : MonoBehaviour
{
    [SerializeField]
    public RPGItem sword;
    public RPGItem hammer;
    public RPGItem bread;

    public RPGItem[] items;

    // Start is called before the first frame update
    void Start()
    {
        sword = new RPGItem();
        sword.name = "Sword";
        sword.id = 1;
        sword.description = "This is a sword";

        hammer = new RPGItem("Hammer", 2, "This is a hammer");

        bread = CreateItem("bread", 2, "I can eat this");

        Debug.Log(items[0].name);
    }

    private RPGItem CreateItem(string name, int id, string description)
    {
        var item = new RPGItem(name, id, description);

        return item;
    }


}
