using UnityEngine;
using UnityEngine.UI;

public class Get : MonoBehaviour
{
    private Inventory inventory;

    public void AddItemToInventory(ItemWorld itemWorld)
    {
        // 添加物品到背包列表
        inventory.AddItem(itemWorld.GetItem());

        // 自毁物体
        itemWorld.DestroySelf();
    }
}