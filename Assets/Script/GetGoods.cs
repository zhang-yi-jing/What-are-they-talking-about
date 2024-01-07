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
        // �����Ʒ�������б�
        inventory.AddItem(itemWorld.GetItem());

        // �Ի�����
        itemWorld.DestroySelf();
    }
}