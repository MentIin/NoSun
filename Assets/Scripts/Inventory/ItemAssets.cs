using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }
    public Dictionary<string, Item> info;

    private void Awake()
    {
        Instance = this;
    }

    public Transform itemPref;

    public Sprite woodSprite;
    public Sprite matchesSprite;
}

