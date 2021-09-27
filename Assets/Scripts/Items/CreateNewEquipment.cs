using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour
{
    private string[] itemDes = new string[3] { "Cool item", "Cooler item", "Not so cool item" };
    private string[] itemNames = new string[3] { "Common", "Great", "Powerfull" };
    private BaseEquipment newEquipment;
    // Start is called before the first frame update
    void Start()
    {
        CreateEquipment();
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.EquipmentType);
    }

    private void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.ItemName = itemNames[Random.Range(0, 3)] + " Item";
        //newEquipment.ItemID = Random.Range(1, 101);
        ChooseItemType();
        newEquipment.ItemDescription = itemDes[Random.Range(0, itemDes.Length)];
    }

    private void ChooseItemType()
    {
        int randomTemp = Random.Range(1, 4);
        if(randomTemp == 1)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.ARMOR;
        }
        else if (randomTemp == 2)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
        }
        else if (randomTemp == 3)
        {
            newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
