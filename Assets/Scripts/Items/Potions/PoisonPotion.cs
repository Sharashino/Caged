using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonPotion : MonoBehaviour
{
    public BasePotion poisonPotion = new BasePotion();
    public GameObject PoisionPotionObject;

    Coroutine poisonPlayer;

    [SerializeField]
    private bool isPoisoned = false;
    void Awake()
    {
        IsPoisoned = isPoisoned;

        poisonPotion.ItemName = "Poision Potion";
        poisonPotion.ItemDescription = "Poisioning Mixture";
        poisonPotion.ItemID = "potion_po";
        poisonPotion.IsOpenable = false;
        poisonPotion.IsPickable = true;
        poisonPotion.ItemType = BaseItem.ItemTypes.POTION;
        poisonPotion.PotionType = BasePotion.PotionTypes.POISON;

        if (gameObject.tag != "PoisionPotion")
        {
            Debug.Log("Not valid " + poisonPotion.ItemName + " Tag");
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            poisonPlayer = StartCoroutine(PoisonPlayer());
        }
        else if (collider.gameObject.tag == "Enemy")
        {
            NumberGen();

            StartCoroutine(PoisonEnemy());
        }
    }
    void NumberGen()
    {
        System.Random ran = new System.Random();
        int num = ran.Next(1, 3);
        Debug.Log(num);

        if(num==1)
        {
            //let monster pickup the item
        }
        else
        {
            //poison monster
        }
    }   //Generuje liczbe i na tej podstawie otruwa przeciwnika lub dodaje do jego ekwipunku
    IEnumerator PoisonEnemy()
    {

        yield return new WaitForSeconds(1);
    }

    IEnumerator PoisonPlayer()
    {
        IsPoisoned = true;
        for (int i = 8; i >= 0; i--)
        {
            if (PoisonPotion.IsPoisoned == false)
            {
                StopCoroutine(poisonPlayer);
            }
            else if(PoisonPotion.IsPoisoned == true)
            {
                PlayerInformation.PlayerHealth -= 4;
                Debug.Log("You have been poisoned, player health - " + PlayerInformation.PlayerHealth);
                yield return new WaitForSeconds(1);
            }
        }
        IsPoisoned = false;
    }

    public static bool IsPoisoned { get; set; }
}

