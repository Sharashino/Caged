using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer
{
    private BaseCharacterClass playerClass;
    private string playerName;

    private int health;                      //zdrowie gracza
    private int damage;                      //obrazenia gracza
    private int armor;                       //pancerz gracza

    private int playerLevel;                 //poziom gracza
    private int gold;                        //zloto gracza
    private int luck;                        //szansa na trafienie krytyczne
    private int agility;                     //szansa na unik
    private int strength;                    //mnoznik obrazen
    private int endurance;                   //mnoznik zdrowia
    private int intelligence;                //mnoznik obrazen magicznych

    private int currentXP;                   //obecne doswiadczenie gracza
    private int requiredXP;                  //potrzebne doswiadczenie do lvlupa
    private int statPointsToAllocate;        //punkty umiejetnosci do przydzielenia

    

    public BaseCharacterClass PlayerClass { get; set; }

    public string PlayerName { get; set; }

    public int Health { get; set; }
    public int Damage { get; set; }
    public int Armor { get; set; }

    public int PlayerLevel { get; set; }
    public int Gold { get; set; }
    public int Luck { get; set; }    
    public int Agility { get; set; }    
    public int Endurance { get; set; }    
    public int Intelligence { get; set; }    
    public int Strength { get; set; }

    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }
    public int StatPointsToAllocate { get; set; }
}
