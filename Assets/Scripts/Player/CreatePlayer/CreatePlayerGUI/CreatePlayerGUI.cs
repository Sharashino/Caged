using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayerGUI : MonoBehaviour
{

    public enum CreatePlayerStates
    {
        CLASSSELECTION, //wyswietl wszystkie klasy
        STATALLOCATION, //przydziel punkty umiejetnosci
        FINALSETUP //podaj imie i inne dane?
    }

    private DisplayCreatePlayerFunctions displayFunctions =  new DisplayCreatePlayerFunctions();
    public static CreatePlayerStates currentState;

    void Start()
    {
        currentState = CreatePlayerStates.CLASSSELECTION;
    }
    void Update()
    {
        switch (currentState)
        {
            case (CreatePlayerStates.CLASSSELECTION):
                break;
            case (CreatePlayerStates.STATALLOCATION):
                break;
            case (CreatePlayerStates.FINALSETUP):
                break;
        }
    }
    void OnGUI()
    {
        displayFunctions.DisplayMainItems();
        if (currentState == CreatePlayerStates.CLASSSELECTION)
        {            
            displayFunctions.DisplayClassSelections();
        }
        else if (currentState == CreatePlayerStates.STATALLOCATION)
        {
            displayFunctions.DisplayStatAllocation();
        }
        else if (currentState == CreatePlayerStates.FINALSETUP)
        {
            displayFunctions.DisplayFinalSetup();
        }
    }
}
