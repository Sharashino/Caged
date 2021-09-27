using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation
{

    //FUNKCJA ZAPISU POSTEPU
    public static void LoadAllInformation()
    {
        GameInformation.PlayerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInformation.PlayerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInformation.Gold = PlayerPrefs.GetInt("PLAYERGOLD");
        GameInformation.Luck = PlayerPrefs.GetInt("PLAYERLUCK");
        GameInformation.Agility = PlayerPrefs.GetInt("PLAYERAGILITY");
        GameInformation.Endurance = PlayerPrefs.GetInt("PLAYERENDURANCE");
        GameInformation.Intelligence = PlayerPrefs.GetInt("PLAYERINTELIGENCE");
        GameInformation.Strength = PlayerPrefs.GetInt("PLAYERSTRENGHT");
        GameInformation.CurrentXP = PlayerPrefs.GetInt("PLAYERCURRENTXP");
        GameInformation.RequiredXP = PlayerPrefs.GetInt("PLAYERREQUIREDXP");

        if (PlayerPrefs.GetString("EQUIPMENT1") != null)
        {
            GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENTITEM1");
        }

        Debug.Log("LOADED ALL INFORMATION");
    }
}
