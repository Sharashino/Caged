using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();

    public GameObject invobj;
    public bool act;
    void Update()
    {
    }

    public bool AddItem(Item itemToAdd, int amount)
    {
        ItemSlot emptySlot = null;
        for(int i = 0; i <slots.Count; i++)
        {
            ItemSlot currentSlot = slots[i].GetComponent<ItemSlot>();
            if(currentSlot.myItem == itemToAdd && itemToAdd.isStackable && currentSlot.myAmount + amount <= itemToAdd.maxStackAmount)
            {
                currentSlot.AddItem(itemToAdd, amount);
                return true;
            }
            else if(currentSlot.myItem == null && emptySlot == null)
            {
                emptySlot = currentSlot;
            }
        }
        if (emptySlot != null)
        {
            emptySlot.AddItem(itemToAdd, amount);
            return true;
        }
        else
        {
            print("Ekwipunek jest pelen!");
            return false;
        }
    }
    public void RemoveItem(Item itemToRemove, int amount)
    {

    }

    //-----------------------------------------------Pomocnik Craftingu----------------------------------------------
    
    public bool HasItem(Item theItem, int amount)
    {
        for(int i = 0; i < slots.Count; i++)
        {
            if(slots[i].GetComponent<CraftingSlot>().myItem != null)
            { 
               // if(slots[i].GetComponent<CraftingSlot>().myItem.itemName == lookUpItem
            }

        }
        return true;
    }
}
