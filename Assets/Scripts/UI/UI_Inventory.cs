using System;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory _inventory;
    public static UI_Inventory current;
    [SerializeField] private Transform itemSlotContainer;
    [SerializeField] private Transform itemSlotPrefab;

    private void Awake()
    {
        current = this;
    }


    public void SetInventory(Inventory inventory)
    {
        _inventory = inventory;
        RefreshInventoryItems();
    }

    public void RefreshInventoryItems()
    {
        foreach (Transform child in itemSlotContainer)
        {
            Destroy(child.gameObject);
        }
        
        foreach (Item item in _inventory.GetItemsList())
        {
            Transform instantce = Instantiate(itemSlotPrefab, itemSlotContainer);
            Image image = instantce.Find("icon").GetComponent<Image>();
            Text amountLabel = instantce.Find("amountLabel").GetComponent<Text>();
            image.sprite = item.GetSprite();
            if (item.amount > 1)
            {
                amountLabel.text = item.amount.ToString();
            }
            else
            {
                amountLabel.gameObject.SetActive(false);
            }
            

        }
    }
}
