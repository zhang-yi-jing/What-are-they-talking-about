using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogFollow : MonoBehaviour
{
    public GameObject dialogBox; // 对话框的UI面板
    public TMP_Text dialogText; // 对话框的文本组件
    public Transform followTarget; // 跟随的目标，这里是NPC对象

    private void Update()
    {
        if (followTarget != null)
        {
            // 计算目标上方1米的位置
            Vector3 targetPosition = followTarget.position + Vector3.up * 0.8f;

            // 将目标位置转换为屏幕坐标
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(targetPosition);

            // 让对话框跟随目标位置
            dialogBox.transform.position = screenPosition;
        }
    }

    public void ShowDialog(string text)
    {
        dialogText.text = text;
        dialogBox.SetActive(true);
    }

    public void HideDialog()
    {
        dialogBox.SetActive(false);
    }
}