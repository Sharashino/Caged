using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IncreaseExpireince
{ 
    private static int xpToGive;
    private static LevelUP levelUpScript = new LevelUP();

    public static void AddExpirience(int xp)
    {    
        xpToGive = xp;
        GameInformation.CurrentXP += xpToGive;

        CheckToSeeIfPlayerLeveled();
    }
    private static void CheckToSeeIfPlayerLeveled()
    {
        if(GameInformation.CurrentXP >= GameInformation.RequiredXP)
        {
            //gracz awansowal na wyzszy poziom
            levelUpScript.LevelUpCharacter();

            

        }
    }
}
