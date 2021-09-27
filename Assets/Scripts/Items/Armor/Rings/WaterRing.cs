using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRing : BaseRing
{
    public WaterRing()
    {
        ItemName = "Water Ring";
        ItemDescription = "Golden ring with blue gem";
        ItemID = "ring_wa";
        ItemType = ItemTypes.RING;
        RingType = RingTypes.WATER;

        
    }
}