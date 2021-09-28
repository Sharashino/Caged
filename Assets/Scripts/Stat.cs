using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stat
{
    [SerializeField] private string statName = default;
    [SerializeField] private int baseValue = default;

    public List<int> modifiers = new List<int>();

    public string StatName => statName;

    public int BaseValue
    {
        get
        {
            int finalValue = baseValue;
            modifiers.ForEach(x => finalValue += x);

            return finalValue;
        }
        set => baseValue = value;
    }

    public void AddModifier(int modifier)
    {
        if(modifier != 0)
        {
            modifiers.Add(modifier);
        }
    }

    public void RemoveModifier(int modifier)
    {
        if (modifier != 0)
        {
            modifiers.Remove(modifier);
        }
    }
}