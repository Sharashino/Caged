using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRing : BaseRing
{
    public   FireRing()
    {
        ItemName = "Fire Ring";
        ItemDescription = "Golden ring with red gem";
        ItemID = "ring_fi";
        ItemType = ItemTypes.RING;
        RingType = RingTypes.FIRE;
    }
}