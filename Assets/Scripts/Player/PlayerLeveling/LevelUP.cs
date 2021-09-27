using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUP
{
    StatAllocationModule lvlupPoint = new StatAllocationModule();
    public int maxPlayerLevel = 30;

    public void LevelUpCharacter()
    {
        //sprawdz czy obecne xp > potrzebne xp
        if(GameInformation.CurrentXP > GameInformation.RequiredXP)
        {
            GameInformation.CurrentXP -= GameInformation.RequiredXP;
        }
        else
        {
            GameInformation.CurrentXP = 0;
        }
        if(GameInformation.PlayerLevel < maxPlayerLevel)
        {
            GameInformation.PlayerLevel += 1;
        }
        else
        {
            GameInformation.PlayerLevel = maxPlayerLevel;
        }
        //ile do nastepnego poziomu?
    }

    public void DetermineRequiredXP()
    {
        int temp = (GameInformation.PlayerLevel+1) * 100;
        GameInformation.RequiredXP = temp;
    }

    private void GiveSkillpoints()
    {
        //lvlupPoint.pointsToAllocate = 
        //daj graczowi jeden punkt umiejetnosci
    }

    private void RestoreHealthMana()
    {
        //odnow graczowi mane/zdrowie
        PlayerInformation.PlayerHealth = PlayerInformation.PlayerMaxHealth;
        PlayerInformation.PlayerMana = PlayerInformation.PlayerMaxMana;
    }

}
