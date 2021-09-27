using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public BasePotion healthPotion = new BasePotion();
    public GameObject HealthPotionObject;
   
    //private int PlayerHealth;
    void Awake()
    {
            healthPotion.ItemName = "Health Potion";
            healthPotion.ItemDescription = "Healing mixture";
            healthPotion.ItemID = "potion_hp";
            healthPotion.IsOpenable = false;
            healthPotion.IsPickable = true;
            healthPotion.ItemType = BaseItem.ItemTypes.POTION;
            healthPotion.PotionType = BasePotion.PotionTypes.HEALTH;
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            if (PlayerInformation.PlayerMaxHealth > PlayerInformation.PlayerHealth)
            {
                PlayerInformation.PlayerHealth += 25;

                if (PlayerInformation.PlayerHealth >= PlayerInformation.PlayerMaxHealth)
                {
                    PlayerInformation.PlayerHealth = PlayerInformation.PlayerMaxHealth;
                    Debug.Log("After Healing with potion youre max health");
                    //Destroy(gameObject);
                }
                else Debug.Log("After Healing with potion your health is - " + PlayerInformation.PlayerHealth);
            }
        }
    }

}
