using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon : BaseItem
{
    public enum WeaponTypes
    {
        BOMB,
        DAGGER,
        SWORD,
        STAFF,
        GREATSWORD
    }
    
    private int weaponDamage;
    private float weaponAttackSpeed;
    private int weaponDurability;
    
    private WeaponTypes weaponTypes;
    public WeaponTypes WeaponType { get; set; }
    public int WeaponDamage { get; set; }
    public int WeaponDurability { get; set; }
    public float WeaponAttackSpeed { get; set; }


    


}