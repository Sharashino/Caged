using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatAllocationModule 
{
    private string[] statNames = new string[5] { "Luck", "Agility", "Endurance", "Intelligence", "Strenght" };
    private string[] statDescriptions = new string[5] { "Critical chance modifier", "Dodge chance modifier", "Health modifier", "Magical damage modifier", "Physical damage modifier" };
    private bool[] statSelections = new bool[5];
    public int[] pointsToAllocate = new int[5];    
    private int[] baseStatPoints = new int[6];      //podstawowe statystyki klasy

    public int availPoints = 5; //ile punktow do rozdania
    public bool didRunOnce = false;

    public void DisplayStatAllocationModule()
    {
        if(!didRunOnce)
        {
            RetrieveStatBaseStatPoints();
            didRunOnce = true;
        }

        DisplayStatToggleSwitches();
        DisplayStatIncreaseDecreaseButtons();
    }

    private void DisplayStatToggleSwitches()
    {
        for (int i = 0; i < statNames.Length; i++)
        {
            statSelections[i] = GUI.Toggle(new Rect(10, 10 + (i * 60), 100, 50), statSelections[i], statNames[i]);
            GUI.Label(new Rect(100, 60*i + 10, 50, 50), pointsToAllocate[i].ToString());
            if (statSelections[i])
            {
                GUI.Label(new Rect(20, 60 * i + 30, 150, 100), statDescriptions[i]);
            }
        }
    }

    private void DisplayStatIncreaseDecreaseButtons()       //Wyswietla przyciski do obslugi ustawiania statystyk
    {
        for(int i = 0; i < pointsToAllocate.Length; i++)
        {
            if(pointsToAllocate [i] >= baseStatPoints [i] && availPoints > 0)
            {
                if (GUI.Button(new Rect(200, 60 * i + 10, 50, 50), "+"))
                {
                    pointsToAllocate[i] += 1;
                    --availPoints;
                }
            }
            if (pointsToAllocate[i] > baseStatPoints[i])
            {
                if (GUI.Button(new Rect(260, 60 * i + 10, 50, 50), "-"))
                {
                    pointsToAllocate[i] -= 1;
                    ++availPoints;
                }
            }               
        }
    }

    private void RetrieveStatBaseStatPoints()
    {
        BaseCharacterClass cClass = GameInformation.PlayerClass;

        pointsToAllocate[0] = cClass.Luck;
        baseStatPoints[0] = cClass.Luck;

        pointsToAllocate[1] = cClass.Agility;
        baseStatPoints[1] = cClass.Agility;

        pointsToAllocate[2] = cClass.Endurance;
        baseStatPoints[2] = cClass.Endurance;

        pointsToAllocate[3] = cClass.Intelligence;
        baseStatPoints[3] = cClass.Intelligence;

        pointsToAllocate[4] = cClass.Strength;
        baseStatPoints[4] = cClass.Strength;
    }
}
