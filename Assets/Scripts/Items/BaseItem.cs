using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem  
{
    private static bool hasPickedUp = false;
    [SerializeField]
    private bool isPickable;
    [SerializeField]
    private bool isOpenable;
    [SerializeField]
    private bool isEquipable;
    [SerializeField]
    private string itemName;
    [SerializeField]
    private string itemDescription;
    [SerializeField]
    private string itemID;

    private int luck;
    private int agility;
    private int strength;
    private int endurance;
    private int intelligence;

    public enum ItemTypes
    {
        ARMOR,
        WEAPON,
        POTION,
        KEY,
        RING,
        CHEST
    }
    private ItemTypes itemType;

    public string ItemName { get { return itemName; } set { itemName = value; } }    
    public string ItemDescription { get { return itemDescription; } set { itemDescription = value; } }  
    public string ItemID { get { return itemID; } set { itemID = value; } }
    public ItemTypes ItemType { get { return itemType; } set { itemType = value; } }
    public int Luck { get { return luck; } set { luck = value; } }
    public int Agility { get { return agility; } set { agility = value; } }
    public int Endurance { get { return endurance; } set { endurance = value; } }
    public int Intelligence { get { return intelligence; } set { intelligence = value; } }
    public int Strength { get { return strength; } set { strength = value; } }
    public bool IsPickable { get { return isPickable; } set { isPickable = value; } }
    public bool IsEqipable { get { return isPickable; } set { isPickable = value; } }
    public bool IsOpenable { get { return isOpenable; } set { isOpenable = value; } }
    public bool HasPickedUp { get { return hasPickedUp; } set { hasPickedUp = value; } }


}
