using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRogueClass : BaseCharacterClass
{
    public BaseRogueClass()
    {
        //Rouge Descriptions
        CharacterClassName = "Rouge";
        CharacterClassDescription = "A fancy pilferer, who seems to be very lucky";

        //Rouge Stats
        MaxHealth = 60 + GameInformation.Endurance * 4;
        Health = 100;
        Damage = GameInformation.Strength * 4;
        Armor = 0;
        Strength = 3;
        Luck = 15;
        Agility = 15;
        Endurance = 10;
        Intelligence = 5;
        Gold = 0;

        MainStat = MainStatsBonuses.LUCK;
        SecondStat = SecondStatsBonuses.AGILITY;
    }
}

