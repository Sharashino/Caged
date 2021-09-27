using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private Camera screenCamera;
    public ItemDatabase dataBase;
    public Inventory inventory;

    private void Start()
    {
        screenCamera = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("E"))
        {
            Ray ray = screenCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 80f))
            {
                if(hit.collider.GetComponent<Item>() != null)
                {
                    
                }
            }
        }
    }

    
}
