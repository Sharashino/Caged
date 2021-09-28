using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : Item
{
    [SerializeField] private float potionDuration;

    public override void Use()
    {
        base.Use();
        Debug.Log("Used potion");
    }
}
