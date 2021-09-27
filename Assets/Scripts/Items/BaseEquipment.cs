using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEquipment : BaseItem
{
    public enum EquipmentTypes
    {
        ARMOR,
        NECK,
        RING
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;  //for future spell effects 

    public EquipmentTypes EquipmentType { get; set; }
    public int SpellEffectID { get; set; }
}
