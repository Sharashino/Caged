using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseRing : BaseItem
{
    public enum RingTypes
    {
        WATER,
        EARTH,
        FIRE
    }

    private RingTypes ringType;

    public RingTypes RingType { get; set; }

}
