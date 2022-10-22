using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    //public static GameManager current;
    public UI_Inventory uiInventory;

    public static GameManager current { get; private set; }

    private void Awake()
    {
        if (current != null && current != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            current = this; 
        }
    }


    private void Start()
    {
        ItemWorld.Spawn(new Vector2(1, 1), new Item {amount = 1, itemType = Item.ItemType.Wood});
        ItemWorld.Spawn(new Vector2(-1, 1), new Item {amount = 1, itemType = Item.ItemType.Wood});
        ItemWorld.Spawn(new Vector2(1, -1), new Item {amount = 1, itemType = Item.ItemType.Matches});
        ItemWorld.Spawn(new Vector2(-1, -1), new Item {amount = 1, itemType = Item.ItemType.Matches});
    }
}
