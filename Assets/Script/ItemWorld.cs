using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static UnityEditor.Progress;

public class ItemWorld : MonoBehaviour
{
    private Item item;

    public void SetItem(Item item)
    {
        this.item = item;
    }
    public Item GetItem()
    {
        return item;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
