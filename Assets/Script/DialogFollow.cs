using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogFollow : MonoBehaviour
{
    public GameObject dialogBox; // �Ի����UI���
    public TMP_Text dialogText; // �Ի�����ı����
    public Transform followTarget; // �����Ŀ�꣬������NPC����

    private void Update()
    {
        if (followTarget != null)
        {
            // ����Ŀ���Ϸ�1�׵�λ��
            Vector3 targetPosition = followTarget.position + Vector3.up * 0.8f;

            // ��Ŀ��λ��ת��Ϊ��Ļ����
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(targetPosition);

            // �öԻ������Ŀ��λ��
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