﻿using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Transform itemPref;

    public Sprite woodSprite;
    public Sprite matchesSprite;
}