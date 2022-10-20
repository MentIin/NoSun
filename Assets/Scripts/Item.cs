using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Wood, Matches
    };

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Wood: return ItemAssets.Instance.woodSprite;
            case ItemType.Matches: return ItemAssets.Instance.matchesSprite;
        }
    }

}
