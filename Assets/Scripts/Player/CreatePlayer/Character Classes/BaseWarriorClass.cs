using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWarriorClass : BaseCharacterClass
{
    public BaseWarriorClass()
    {
        //Warrior Descriptions
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A brave man, who fears nothing and no one";

        //Warrior Stats
        MaxHealth = 60 + GameInformation.Endurance * 4;
        Health = 120;
        Damage = GameInformation.Strength * 4;
        Armor = 0;
        Strength = 4;
        Luck = 5;
        Agility = 5;
        Endurance = 15;
        Intelligence = 5;
        Gold = 0;

        MainStat = MainStatsBonuses.STRENGHT;
        SecondStat = SecondStatsBonuses.ENDURANCE;
    }
}
