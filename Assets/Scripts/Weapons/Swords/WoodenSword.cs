using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodenSword : BaseWeapon
{
    public WoodenSword()
    {
        ItemName = "Wooden Sword";
        ItemDescription = "Sword made of wood, won't do much damage but will keep you alive";
        ItemID = "sword_wo";
        ItemType = ItemTypes.WEAPON;
        WeaponType = WeaponTypes.SWORD;

        WeaponDamage = 2;
        WeaponDurability = 25;
        WeaponAttackSpeed = 1;

        if (WeaponDurability == 0)
        {
            //przedmiot ulegl zniszczeniu
        }
    }
}