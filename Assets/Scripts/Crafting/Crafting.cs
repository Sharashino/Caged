using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Crafting : MonoBehaviour
{
    public ItemDatabase dataBase;
    public Inventory inventory; 

    public GameObject craftingPanel;
    public GameObject craftingSlot;

    void Start()
    {
        GenSlots();    
    }

    void GenSlots()
    {   
        for(int i = 0; i < dataBase.dataBaseItems.Count; i++)
        {
            Item currentItem = dataBase.dataBaseItems[i];
            if(currentItem.isCraftable)
            {
                GameObject go = Instantiate(craftingSlot, craftingPanel.transform.position, Quaternion.identity);
                go.transform.SetParent(craftingPanel.transform);
                go.GetComponent<CraftingSlot>().myItem = currentItem;
            }
        }
    }
    public void CraftItem(Item itemToCraft)
    {
        if (itemToCraft.isCraftable)
        {
            if (CanCraft(itemToCraft))
            {
                Add(itemToCraft);
            }
            else print("Cant craft this item");
        }
        else return;
    }
    bool CanCraft(Item itemToLookUp)
    {
        for(int i = 0; i < itemToLookUp.craftItems.Count; i++)
        {
            Item currentItem = itemToLookUp.craftItems[i];
            int currentAmount = itemToLookUp.craftAmount[i];
            /*if(!inventory.HasItem(currentItem.itemName, currentAmount))
            {
                return false;
            }*/
        }
        return true;
    }
    void Add(Item itemToAdd)
    {

    }
    void Remove(Item itemToRemove)
    {

    }
}
