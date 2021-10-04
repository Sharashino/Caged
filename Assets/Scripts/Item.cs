using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string itemName;
    [SerializeField] private int itemID;

    public void PickUp()
    {
        if (Inventory.Instance.Add(this))
            Destroy(this);
    }

    public virtual void Use()
    {
        Debug.Log($"Used item {itemName}");
    }
}
