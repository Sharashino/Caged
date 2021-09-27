using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ZACHOWUJE WSZYSTKIE INFORMACJE O GRACZU
public class GameInformation : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static string ChosenClass { get; set; }
    public static BaseEquipment EquipmentOne{ get; set; } 
    public static string PlayerName { get; set; }
    public static int PlayerLevel { get; set; }
    public static BaseCharacterClass PlayerClass { get; set; }
    public static int Gold { get; set; }
    public static int Luck { get; set; }
    public static int Agility { get; set; }
    public static int Endurance { get; set; }
    public static int Intelligence { get; set; }
    public static int Strength { get; set; }
    public static int CurrentXP { get; set; }
    public static int RequiredXP { get; set; }
    public static int MaxHealth { get; set; }
    public static int Health { get; set; }
    public static int Armor { get; set; }
    public static int Damage { get; set; }
    public static int Mana { get; set; }
}
