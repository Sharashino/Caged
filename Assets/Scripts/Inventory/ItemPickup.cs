using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Item
{
    public Item item;
    public Inventory inventory;

    /*public override void Interract()
    {
        bool hasPickedup = inventory.AddItem(item, 1);
        if(!hasPickedup)
        {
            Debug.Log("Your inventory is full");
        }
        else
        {
            //Destroy(gameObject);
        }
    }*/
}
