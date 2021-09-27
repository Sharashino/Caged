using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurePotion : MonoBehaviour
{
    public BasePotion curePotion = new BasePotion();
    public GameObject CurePotionObject;

    //private int PlayerHealth;
    void Awake()
    {
        curePotion.ItemName = "Cure Potion";
        curePotion.ItemDescription = "Cures all your desieses";
        curePotion.ItemID = "potion_cu";
        curePotion.IsOpenable = false;
        curePotion.IsPickable = true;
        curePotion.ItemType = BaseItem.ItemTypes.POTION;
        curePotion.PotionType = BasePotion.PotionTypes.CURE;

        if (gameObject.tag != "CurePotion")
        {
            Debug.Log("Not valid " + curePotion.ItemName + " Tag");
            Destroy(gameObject);
        } 
    }

    private bool isp = false;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if(PoisonPotion.IsPoisoned == true)
            {
                PoisonPotion.IsPoisoned = isp;

                Debug.Log("You have been cured!");
                Debug.Log(PlayerInformation.PlayerHealth);
            }
            //jesli gracz jest otruty usun trucizne     
            //jesli przeciwnik jest otruty usn trucizne             
            //jesli przeciwnik nie jest otruty dodaj do jego ekwipunku
        }
    }
}
