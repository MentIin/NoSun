using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public static GameManager current;
    public UI_Inventory uiInventory;

    private void Awake()
    {
        current = this;
    }

    private void Start()
    {
        Collectibles.Spawn(new Vector2(1, 1), new Item {amount = 1, itemType = Item.ItemType.Wood});
        Collectibles.Spawn(new Vector2(-1, 1), new Item {amount = 1, itemType = Item.ItemType.Wood});
    }
}
