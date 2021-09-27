using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoading : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadInformation.LoadAllInformation();

        Debug.Log("Player Name: " + GameInformation.PlayerName);
        Debug.Log("LOADING COMPLETE");
    }
}
