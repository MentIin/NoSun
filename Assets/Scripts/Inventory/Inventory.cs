using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> _itemList;
    
    public Inventory()
    {
        _itemList = new List<Item>();
    }

    public void AddItem(Item item)
    {
        bool inInventory = false;
        if (item.isStackable)
        {
            foreach (Item inventoryItem in _itemList)
            {
                if (inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += 1;
                    inInventory = true;
                    break;
                }
            }
        }
        if (!inInventory)
        {
            _itemList.Add(item);
        }
        
        UI_Inventory.current.RefreshInventoryItems();
    }

    public List<Item> GetItemsList()
    {
        return _itemList;
    }
}
