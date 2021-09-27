using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{
    //FUNKCJA WCZYTANIA POSTEPU
    public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
        PlayerPrefs.SetInt("PLAYERGOLD", GameInformation.Gold);
        PlayerPrefs.SetInt("PLAYERLUCK", GameInformation.Luck);
        PlayerPrefs.SetInt("PLAYERAGILITY", GameInformation.Agility);
        PlayerPrefs.SetInt("PLAYERENDURANCE", GameInformation.Endurance);
        PlayerPrefs.SetInt("PLAYERINTELLIGENCE", GameInformation.Intelligence);
        PlayerPrefs.SetInt("PLAYERSTRENGHT", GameInformation.Strength);
        PlayerPrefs.SetInt("PLAYERCURRENTXP", GameInformation.CurrentXP);
        PlayerPrefs.SetInt("PLAYERREQUIREDXP", GameInformation.RequiredXP);

        if(GameInformation.EquipmentOne != null)
        {
            PPSerialization.Save("EQUIPMENTITEM1", GameInformation.EquipmentOne);
        }
        Debug.Log("SAVED ALL INFORMATION");
    }
}
