using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BasePotion : BaseItem
{
    public enum PotionTypes
    {
        HEALTH,
        MANA,
        CURE,   
        POISON
    }
    private PotionTypes potionType;
    public PotionTypes PotionType { get; set; }
}
