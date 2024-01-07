using UnityEngine;
using UnityEngine.UI;

public class GetGoods : MonoBehaviour

{
    private Inventory inventory;
    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    public void AddItemToInventory(ItemWorld itemWorld)
    {
        // 添加物品到背包列表
        inventory.AddItem(itemWorld.GetItem());

        // 自毁物体
        itemWorld.DestroySelf();
    }
}