using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceItem
{
    public string name;
    public int itemID;

    public static int itemCount;

    public InstanceItem()
    {
        itemCount++;
    }
}

public class InstancePlayer
{
    public int id;
    public string name;

    public static int connectionCount;

    public InstancePlayer()
    {
        connectionCount++;
    }
}

public class Test_Static2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InstanceItem sword = new InstanceItem();
        InstanceItem bread = new InstanceItem();
        InstanceItem cape = new InstanceItem();
        InstanceItem fish = new InstanceItem();

        Debug.Log("Item Count: " + InstanceItem.itemCount);

        InstancePlayer p1 = new InstancePlayer();
        InstancePlayer p2 = new InstancePlayer();
        InstancePlayer p3 = new InstancePlayer();
        InstancePlayer p4 = new InstancePlayer();

        Debug.Log("Players on server: " + InstancePlayer.connectionCount);
    }
}
