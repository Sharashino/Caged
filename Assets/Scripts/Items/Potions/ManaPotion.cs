using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotion : MonoBehaviour
{
    public BasePotion manaPotion = new BasePotion();
    public GameObject ManaPotionObject;

    void Awake()
    {
        manaPotion.ItemName = "Mana Potion";
        manaPotion.ItemDescription = "A potion that refills your mana";
        manaPotion.ItemID = "potion_ma";
        manaPotion.IsOpenable = false;
        manaPotion.IsPickable = true;
        manaPotion.ItemType = BaseItem.ItemTypes.POTION;
        manaPotion.PotionType = BasePotion.PotionTypes.MANA;

        if (gameObject.tag != "ManaPotion")
        {
            Debug.Log("Not valid " + manaPotion.ItemName + " Tag");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (PlayerInformation.PlayerMaxMana > PlayerInformation.PlayerMana)
            {
                PlayerInformation.PlayerMana += 25;
                Debug.Log("After refilling your mana is - " + PlayerInformation.PlayerMana);
                if (PlayerInformation.PlayerMana >= PlayerInformation.PlayerMaxMana)
                {
                    PlayerInformation.PlayerMana = PlayerInformation.PlayerMaxMana;
                    Debug.Log("After refilling youre max mana");
                    //Destroy(gameObject);
                }
            }
        }
        else if (collider.gameObject.tag == "Enemy")
        {
            //jesli podniesie przeciwnik to przenies do jego ekwipunku
        }
    }
}