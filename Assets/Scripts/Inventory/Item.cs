using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public bool isStackable;
    public int maxStackAmount;

    public bool isCraftable;
    public bool isUsable;

    public bool useDurability;
    public int maxDurability;
    public int currentDurability;
    public List<Item> craftItems = new List<Item>();
    public List<int> craftAmount = new List<int>();

}
