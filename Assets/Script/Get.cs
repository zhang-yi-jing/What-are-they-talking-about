using UnityEngine;
using UnityEngine.UI;

public class Get : MonoBehaviour
{
    private Inventory inventory;

    public void AddItemToInventory(ItemWorld itemWorld)
    {
        // �����Ʒ�������б�
        inventory.AddItem(itemWorld.GetItem());

        // �Ի�����
        itemWorld.DestroySelf();
    }
}