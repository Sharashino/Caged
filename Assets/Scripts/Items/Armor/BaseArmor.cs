using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseArmor : BaseItem
{
    public enum ArmorTypes
    {
        CHEST,
        NECKLEACE,
        RING
    }
    private ArmorTypes armorType;
    public ArmorTypes ArmorType { get; set; }
}
