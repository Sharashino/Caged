using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenDagger : MonoBehaviour
{
    public BaseWeapon woodenDagger = new BaseWeapon();

    private void Awake()
    {
        woodenDagger.ItemName = "Wooden Dagger";
        woodenDagger.ItemDescription = "Healing mixture";
        woodenDagger.ItemID = "wooden_Dagger";
        woodenDagger.ItemType = BaseItem.ItemTypes.WEAPON;
        woodenDagger.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
        
         
    }

}
