using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{
    public LevelUP levelUP = new LevelUP();

    //przechowuje wszystkie informacje o obecnym stanie gracza
    //chcemy wiedziec jaka klase ma gracz
    //jakie czynniki wplywaja na jego statystyki (zycie/obrazenia/pancerz)
    //przechowujemy jego stan ekwipunku
    //to ile ma pieniedzy

    [SerializeField]
    private string playerClass;
    
    [SerializeField]
    private int playerHealth;
    [SerializeField]
    private int playerMaxHealth;
    [SerializeField]
    private int playerDamage;
    [SerializeField]
    private int playerArmor;
    [SerializeField]
    private int playerMaxMana;
    [SerializeField]
    private int playerMana;
    [SerializeField]
    private int playerGold;

    [SerializeField]
    private int playerCurrentXP;
    [SerializeField]
    private int playerRequiredXP;
    [SerializeField]
    private int playerLevel;

    [SerializeField]
    private int playerEndurance;
    [SerializeField]
    private int playerIntelligence;
    [SerializeField]
    private int playerAgility;
    [SerializeField]
    private int playerStrenght;
    [SerializeField]
    private int playerLuck;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        levelUP.DetermineRequiredXP();
    }

    private void Start()
    {
        PlayerClass = GameInformation.ChosenClass;
        /*
            wybrana klasa przez gracza
             [Rogue] [Mage] [Warrior]
        */
        PlayerMaxHealth = 60 + GameInformation.Endurance * 4;
        PlayerHealth = PlayerMaxHealth;
        PlayerEndurance = GameInformation.Endurance;
        /*
            maksymalne zdrowie gracza
            bazowa ilosc zdrowia to 60
            kazdy punkt w wytrzymalosc to +4 zdrowia
        */
        PlayerDamage = GameInformation.Strength * 4;
        PlayerStrenght = GameInformation.Strength;
        /*
            obrazenia gracza mele
            bazowa ilosc obrazen broni mele to 4
            kazdy punkt w sile to +4 obrazenia     
        */
        PlayerArmor = GameInformation.Armor;

        PlayerMaxMana = 60 + GameInformation.Intelligence * 4;
        PlayerMana = PlayerMaxMana;
        PlayerGold = GameInformation.Gold;
        
        PlayerIntelligence = GameInformation.Intelligence;
        PlayerAgility = GameInformation.Agility;
        PlayerLuck = GameInformation.Luck;
        PlayerLevel = 0;
        PlayerCurrentXP = GameInformation.CurrentXP;
        PlayerRequiredXP = GameInformation.RequiredXP;


        playerClass = PlayerClass;

        playerHealth = PlayerHealth;
        playerMaxHealth = PlayerMaxHealth;

        playerDamage = PlayerDamage;
        playerArmor = PlayerArmor;

        playerMana = PlayerMana;
        playerMaxMana = PlayerMaxMana;

        playerGold = PlayerGold;

        playerEndurance = PlayerEndurance;
        playerIntelligence = PlayerIntelligence;
        playerAgility = PlayerAgility;
        playerStrenght = PlayerStrenght;
        playerLuck = PlayerLuck;

        playerLevel = PlayerLevel;
        playerCurrentXP = PlayerCurrentXP;
        playerRequiredXP = PlayerRequiredXP;
    }

    private void Update()
    {
        playerHealth = PlayerHealth;

        if (PlayerHealth == 0)
        {
            //gracz nie zyje
            KillPlayer();
            //Debug.Log("Player Died");
        }
    }

    void KillPlayer()
    {

    }
    
    public static string PlayerClass { get; set; }
    public static int PlayerHealth { get; set; }
    public static int PlayerMaxHealth { get; set; }
    public static int PlayerDamage { get; set; }
    public static int PlayerArmor { get; set; }
    public static int PlayerGold { get; set; }
    public static int PlayerMaxMana { get; set; }
    public static int PlayerMana { get; set; }
    public static int PlayerCurrentXP { get; set; }
    public static int PlayerRequiredXP { get; set; }
    public static int PlayerLevel { get; set; }
    public static int PlayerEndurance { get; set; }
    public static int PlayerIntelligence { get; set; }
    public static int PlayerAgility { get; set; }
    public static int PlayerStrenght { get; set; }
    public static int PlayerLuck { get; set; }
}
/*public string PlayerClass { get { return playerClass; } set { playerClass = value; } }
    public int PlayerHealth { get { return playerHealth; } set { playerHealth = value; } }
    public int PlayerMaxHealth { get { return playerMaxHealth; } set { playerMaxHealth = value; } }
    public int PlayerDamage { get { return playerDamage; } set { playerDamage = value; } }
    public int PlayerArmor { get { return playerArmor; } set { playerArmor = value; } }
    public int PlayerGold { get { return playerGold; } set { playerGold = value; } }
    public int PlayerCurrentXP { get { return playerCurrentXP; } set { playerCurrentXP = value; } }
    public int PlayerRequiredXP { get { return playerRequiredXP; } set { playerRequiredXP = value; } }
    public int PlayerLevel { get { return playerLevel; } set { playerLevel = value; } }
    public int PlayerEndurance { get { return playerEndurance; } set { playerEndurance = value; } }
    public int PlayerIntelligence { get { return playerIntelligence; } set { playerIntelligence = value; } }
    public int PlayerAgility { get { return playerAgility; } set { playerAgility = value; } }
    public int PlayerStrenght { get { return playerStrenght; } set { playerStrenght = value; } }
    public int PlayerLuck { get { return playerLuck; } set { playerLuck = value; } }*/
