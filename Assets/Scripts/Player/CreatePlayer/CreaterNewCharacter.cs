using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreaterNewCharacter : MonoBehaviour
{
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    private bool isRogueClass;
    private string playerName = "Enter your name...";

    // Start is called before the first frame update
    void Start()
    {
        newPlayer = new BasePlayer();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        playerName = GUILayout.TextArea(playerName, 18);
        isMageClass = GUILayout.Toggle(isMageClass, "Mage Class");
        isWarriorClass = GUILayout.Toggle(isWarriorClass, "Warrior Class");
        isRogueClass = GUILayout.Toggle(isRogueClass, "Rogue Class");

        if (GUILayout.Button("Create"))
        {
            if (isMageClass)
            {
                newPlayer.PlayerClass = new BaseMageClass();
            }
            else if(isWarriorClass)
            {
                newPlayer.PlayerClass = new BaseWarriorClass();
            }
            else if(isRogueClass)
            {
                newPlayer.PlayerClass = new BaseRogueClass();
            }
            CreateNewPlayer();
            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();
        }
    }
    private void StoreNewPlayerInfo()
    {
        GameInformation.PlayerName = newPlayer.PlayerName;
        GameInformation.PlayerLevel = newPlayer.PlayerLevel;
        GameInformation.Agility = newPlayer.Agility;
        GameInformation.Endurance = newPlayer.Endurance;
        GameInformation.Intelligence = newPlayer.Intelligence;
        GameInformation.Strength = newPlayer.Strength;
        GameInformation.Gold = newPlayer.Gold;
    }
    private void CreateNewPlayer()
    {
        newPlayer.PlayerName = playerName;
        newPlayer.PlayerLevel = 1;
        newPlayer.Luck = newPlayer.PlayerClass.Luck;
        newPlayer.Agility = newPlayer.PlayerClass.Agility;
        newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
        newPlayer.Intelligence = newPlayer.PlayerClass.Intelligence;
        newPlayer.Strength = newPlayer.PlayerClass.Strength;
        newPlayer.Gold = newPlayer.PlayerClass.Gold;
    }
}
