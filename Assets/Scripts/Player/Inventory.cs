using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    
    [SerializeField] private List<Item> inventory = new List<Item>();
    [SerializeField] private int inventoryCapacity;

    private void Awake()
    {
        if (!Instance) Instance = this;
    }
    
    public bool Add(Item item)
    {
            inventory.Add(item);
            return true;
        /*else
        {
            Debug.Log("No more inventory space");
            return false;
        }*/
    }

    public void Remove(Item item)
    {
        inventory.Remove(item);
    }

    public void UseItem(Item item)
    {
        inventory.Remove(item);
        item.Use();
    }
}
