using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TestItem2  // VALUE TYPE -- Stack
{
    public string name;
    public int itemID;

    public TestItem2(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class TestItem  // REFERENCE TYPE -- Heap
{
    public string name;
    public int itemID;

    public TestItem(string name, int itemID)
    {
        this.name = name;
        this.itemID = itemID;
    }
}

public class Test : MonoBehaviour
{
    TestItem sword;

    TestItem hammer = new TestItem("Hammer", 2);
    TestItem2 bread;

    private void Start()
    {
        sword = new TestItem("Sword", 1);

        bread.name = "Bread";
        bread.itemID = 3;

        Debug.Log("Class: Reference Type");
        Debug.Log("Weapon to upgrade: " + hammer.name);
        ChangeValue(hammer);
        Debug.Log("Upgraded weapon: " + hammer.name);

        Debug.Log("Struct: Value Type");
        Debug.Log("Food to upgrade: " + bread.name);
        ChangeValue(bread);
        Debug.Log("Upgraded food: " + bread.name);


        // Notes for later

        int age = 25; // value type

        // move value types
        // bool, bytes, char, doubles, float, int, long, structs

        string myName = "John"; // reference type
        
        // more reference types
        // strings, arrays, delegates
    }

    void ChangeValue(TestItem2 structItem) // value type
    {
        structItem.name = "Bread Loaf";
    }

    void ChangeValue(TestItem classItem) // reference type
    {
        classItem.name = "War Hammer";
    }
}