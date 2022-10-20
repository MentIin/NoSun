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
            Image image = instantce.GetChild(0).GetComponent<Image>();
            image.sprite = item.GetSprite();

        }
    }
}
