using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using UnityEngine;

public class CagedItemDatabase : MonoBehaviour
{
    /*public TextAsset itemInventory;
    public static List<BaseItem> inventoryItems = new List<BaseItem>();

    private List<Dictionary<string, string>> inventoryItemsDictionary = new List<Dictionary<string, string>>();
    private Dictionary<string, string> inventoryDictionary;

    private void Awake()
    {
        ReadItemsFromDatabase();
        for(int i = 0; i < inventoryItemsDictionary.Count; i++)
        {
            inventoryItems.Add(new BaseItem(inventoryItemsDictionary[i]));
        }
    }


    public void ReadItemsFromDatabase()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(itemInventory.text);
        XmlNodeList itemList = xmlDocument.GetElementsByTagName("Item");

        foreach(XmlNode itemInfo in itemList)
        {
            XmlNodeList itemContent = itemInfo.ChildNodes;
            inventoryDictionary = new Dictionary<string, string>(); 

            foreach(XmlNode content in itemContent)
            {
                switch(content.Name)
                {
                    case "ItemName":
                        inventoryDictionary.Add("ItemName", content.InnerText);
                        break;
                    case "ItemId":
                        inventoryDictionary.Add("ItemId", content.InnerText);
                        break;
                    case "ItemType":
                        inventoryDictionary.Add("ItemType", content.InnerText);
                        break;
                }   

                inventoryItemsDictionary.Add(inventoryDictionary);
            }
        }
    }*/
}
