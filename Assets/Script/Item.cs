using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        good,
        Coin,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.good: return ItemAssets.Instance.GoodSprite;
            case ItemType.Coin: return ItemAssets.Instance.coinSprite;
        }
    }

}
