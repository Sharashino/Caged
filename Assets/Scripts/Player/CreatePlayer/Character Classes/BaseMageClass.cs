using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMageClass : BaseCharacterClass
{
    public BaseMageClass()
    {
        //Mage Descriptions
        CharacterClassName = "Mage";
        CharacterClassDescription = "A wise and powerfull wizard";

        //Mage Stats
        MaxHealth = 60 + GameInformation.Endurance * 4;
        Health = 80;
        Damage = GameInformation.Strength * 4;
        Armor = 0;
        Strength = 1;
        Luck = 10;
        Agility = 5;
        Endurance = 5;
        Intelligence = 15;
        Gold = 0;

        MainStat = MainStatsBonuses.INTELLIGENCE;
        SecondStat = SecondStatsBonuses.DAMAGE;
    }
}

