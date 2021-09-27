using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMonster
{

    public enum MonsterTypes
    {
        RAT,
        SKELETON,
        ZOMBIE,
        SPIDER
    }

    //opisy potworow
    private string monsterName; 
    private string monsterDescription;

    //statystyki potworow
    public int monsterDamage;
    public int monsterArmor;
    public int monsterHealth;
    public int monsterXP;
    public float monsterSpeed;
    public float monsterAttackSpeed;


    private MonsterTypes monsterType;
    public MonsterTypes MonsterType { get; set; }
    public string MonsterName { get; set; }
    public string MonsterDescription { get; set; }
    public int MonsterDamage { get; set; }
    public int MonsterArmor { get; set; }
    public int MonsterHealth { get; set; }
    public int MonsterXP { get; set; }
    public float MonsterSpeed { get; set; }
    public float MonsterAttackSpeed { get; set; }
}
