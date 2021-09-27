using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public BaseMonster rat = new BaseMonster();
    
    private void Awake()
    {
        rat.MonsterName = "Rat";
        rat.MonsterDescription = "Small creature";
        rat.MonsterHealth = 15;
        rat.monsterDamage = 8;
        rat.monsterArmor = 0;
        rat.MonsterXP = 10;
        rat.MonsterSpeed = 1;
        rat.MonsterAttackSpeed = 0.5f;
        rat.MonsterType = BaseMonster.MonsterTypes.RAT;
    }

    private void Update()
    {
        if(rat.monsterHealth <= 0 ) //i jesli zostal zabity przez gracza
        {
            IncreaseExpireince.AddExpirience(rat.MonsterXP);
        }
    }
}
