using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayCreatePlayerFunctions 
{
    private StatAllocationModule statAllocationModule = new StatAllocationModule();
    private BaseCharacterClass baseCharacterClass = new BaseCharacterClass();

    private int classSelection;
    private string[] classSelectionNames = new string[] { "Mage", "Warrior", "Rogue" };
    private string playerName = "Enter your name"; //player name
    private int playerStrenght;
    private int playerIntelligence;
    private int playerEndurance;
    private int playerAgility;
    private int playerLuck;
    private string playerDesc;
    private string classDesc;

    public void DisplayClassSelections()
    {
        classDesc = baseCharacterClass.CharacterClassDescription;
        classSelection = GUI.SelectionGrid(new Rect(550,225, 250, 75), classSelection, classSelectionNames, 3);
        GUI.Label(new Rect(450, 50, 300, 300), FindClassDescription(classSelection));
        GUI.Label(new Rect(150, 250, 300, 300), FindClassStats(classSelection));
    }

    private string FindClassDescription(int classSelection)
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            return tempClass.CharacterClassDescription;
        }
        else if(classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            return tempClass.CharacterClassDescription;
        }
        else if (classSelection == 2)
        {
            BaseCharacterClass tempClass = new BaseRogueClass();
            return tempClass.CharacterClassDescription;
        }
        return "NO CLASS FOUND";
    }

    private void ChooseClass(int classSelection)
    {
        if(classSelection == 0)
        {
            GameInformation.PlayerClass = new BaseMageClass();
        }
        else if(classSelection == 1)
        {
            GameInformation.PlayerClass = new BaseWarriorClass();
        }
        else if(classSelection == 2)
        {
            GameInformation.PlayerClass = new BaseRogueClass();
        }
    }

    private string FindClassStats(int classSelection)   //wyswietla statystyki danej klasy
    {
        if (classSelection == 0)
        {
            BaseCharacterClass tempClass = new BaseMageClass();
            playerDesc = tempClass.CharacterClassDescription;
            string tempStats = "Health: " + tempClass.Health + "\n" + "Damage: " + tempClass.Damage + "\n" + "Armor: " + tempClass.Armor + "\n" +
                "Strenght: " + tempClass.Strength + "\n" + "Luck: " + tempClass.Luck + "\n" + "Agility: " + tempClass.Agility + "\n" + "Endurance: "
                + tempClass.Endurance + "\n" + "Intelligence: " + tempClass.Intelligence;
            
            return tempStats;
        }
        else if (classSelection == 1)
        {
            BaseCharacterClass tempClass = new BaseWarriorClass();
            playerDesc = tempClass.CharacterClassDescription;
            string tempStats = "Health: " + tempClass.Health + "\n" + "Damage: " + tempClass.Damage + "\n" + "Armor: " + tempClass.Armor + "\n" +
                "Strenght: " + tempClass.Strength + "\n" + "Luck: " + tempClass.Luck + "\n" + "Agility: " + tempClass.Agility + "\n" + "Endurance: "
                + tempClass.Endurance + "\n" + "Intelligence: " + tempClass.Intelligence;
          
            return tempStats;
        }
        else if (classSelection == 2)
        {
            BaseCharacterClass tempClass = new BaseRogueClass();
            playerDesc = tempClass.CharacterClassDescription;
            string tempStats = "Health: " + tempClass.Health + "\n" + "Damage: " + tempClass.Damage + "\n" + "Armor: " + tempClass.Armor + "\n" +
                "Strenght: " + tempClass.Strength + "\n" + "Luck: " + tempClass.Luck + "\n" + "Agility: " + tempClass.Agility + "\n" + "Endurance: "
                + tempClass.Endurance + "\n" + "Intelligence: " + tempClass.Intelligence;

            return tempStats;
        }
        return "NO STATS FOUND";
    }

    public void DisplayMainItems()
    {
        if(CreatePlayerGUI.currentState != CreatePlayerGUI.CreatePlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(470, 370, 50, 50), "NEXT")) //jesli nie jestesmy na final setup pokazuj next button
            {
                if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.CLASSSELECTION)
                {
                    ChooseClass(classSelection);
                    CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.STATALLOCATION;
                }
                else if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.STATALLOCATION)
                {
                    GameInformation.Luck = statAllocationModule.pointsToAllocate[0];
                    GameInformation.Agility = statAllocationModule.pointsToAllocate[1];
                    GameInformation.Endurance = statAllocationModule.pointsToAllocate[2];
                    GameInformation.Intelligence = statAllocationModule.pointsToAllocate[3];
                    GameInformation.Strength = statAllocationModule.pointsToAllocate[4];
                    
                    switch(classSelection)
                    {
                        case 0: //mage
                            BaseCharacterClass mageClass = new BaseMageClass();
                            GameInformation.ChosenClass = "Mage";
                            GameInformation.Damage = GameInformation.Strength * 4;
                            GameInformation.Armor = mageClass.Armor;
                            GameInformation.Health = mageClass.Health;
                            GameInformation.MaxHealth = 60 + GameInformation.Endurance *4;
                            GameInformation.Gold = mageClass.Gold;

                            break;
                        case 1: //warior
                            BaseCharacterClass warriorClass = new BaseWarriorClass();
                            GameInformation.ChosenClass = "Warrior";
                            GameInformation.Damage = GameInformation.Strength * 4;
                            GameInformation.Armor = warriorClass.Armor;
                            GameInformation.Health = warriorClass.Health;
                            GameInformation.MaxHealth = 60 + GameInformation.Endurance * 4;
                            GameInformation.Gold = warriorClass.Gold;
                            break;
                        case 2: //rogue
                            BaseCharacterClass rogueClass = new BaseRogueClass();
                            GameInformation.ChosenClass = "Rogue";
                            GameInformation.Damage = GameInformation.Strength * 4;
                            GameInformation.Armor = rogueClass.Armor;
                            GameInformation.Health = rogueClass.Health;
                            GameInformation.MaxHealth = 60 + GameInformation.Endurance * 4;
                            GameInformation.Gold = rogueClass.Gold;
                            break;
                    }
                    CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.FINALSETUP;
                }
            }
        }
        else if(CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.FINALSETUP)
        {
            if (GUI.Button(new Rect(470, 370, 50, 50), "FINISH"))
            {

                //finalny zapis
                GameInformation.PlayerName = playerName;
                
                SaveInformation.SaveAllInformation();
                Debug.Log("Made a final save");
                DisplayFinalSetup();
            }
        }
        if(CreatePlayerGUI.currentState != CreatePlayerGUI.CreatePlayerStates.CLASSSELECTION)
        {
            if (GUI.Button(new Rect(290, 370, 50, 50), "BACK"))
            {            
                if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.STATALLOCATION)
                {
                    statAllocationModule.didRunOnce = false;
                    GameInformation.PlayerClass = null;
                    statAllocationModule.availPoints = 5;
                    CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.CLASSSELECTION;
                }
                else if (CreatePlayerGUI.currentState == CreatePlayerGUI.CreatePlayerStates.FINALSETUP)
                {
                    CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.STATALLOCATION;
                }
            }
        }      
    }
    
    public void DisplayStatAllocation()
    {
        statAllocationModule.DisplayStatAllocationModule();
    }
    public void DisplayFinalSetup()
    {
        if(GUI.Button(new Rect(670, 370, 50, 50), "FINISH1"))
        {
            SaveInformation.SaveAllInformation();
            //rozpocznij gre
            //finalny zapis
            Debug.Log("Make final save");
            SceneManager.LoadScene("Caged");

        }
        playerName = GUI.TextArea(new Rect(20, 10, 100, 35), playerName, 18);
        
        playerDesc = GUI.TextArea(new Rect(20,90,250,200),playerDesc,50);
    }
}
