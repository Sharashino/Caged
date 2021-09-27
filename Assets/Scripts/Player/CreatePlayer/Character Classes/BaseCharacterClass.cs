using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass 
{
    //opisy gracza
    private string characterClassName;
    public string characterClassDescription;

    //Stats
    private int maxHealth;
    private int health;
    private int damage;
    private int armor;
    private int luck;
    private int agility;
    private int strength;
    private int endurance;
    private int intelligence;
    private int gold;
    
    public enum MainStatsBonuses
    {
        LUCK,
        INTELLIGENCE,
        STRENGHT
    }
    public enum SecondStatsBonuses
    {
        AGILITY,
        ENDURANCE,
        DAMAGE
    }

    public MainStatsBonuses MainStat { get; set; }
    public SecondStatsBonuses SecondStat { get; set; }
    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }
    public string CharacterClassName { get; set; }
    public string CharacterClassDescription { get; set; }
    public int Luck { get; set; }
    public int Agility { get; set; }
    public int Endurance { get; set; }
    public int Intelligence { get; set; }
    public int Strength { get; set; }
    public int Gold { get; set; }
}
