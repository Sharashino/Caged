using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRing : BaseRing
{
    public BaseRing earthRing = new BaseRing();
    public GameObject EarthRingObject;

    void Awake()
    {
        earthRing.ItemName = "Earth Ring";
        earthRing.ItemDescription = "A ring with green gem";
        earthRing.ItemID = "ring_ea";
        earthRing.IsPickable = true;
        earthRing.IsOpenable = false;
        earthRing.IsEqipable = true;
        earthRing.ItemType = BaseItem.ItemTypes.RING;
        earthRing.RingType = BaseRing.RingTypes.EARTH;
    }

    void OnTriggerEnter(Collider collider)
    {
        //po podniesieniu wrzuc do ekwipunku
    }

    //jesli gracz zalozyl przedmiot to zwieksz jego statystki

}
