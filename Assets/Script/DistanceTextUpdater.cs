using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTextUpdater : MonoBehaviour
{
    public Transform objectA; // ����A��Transform
    public Transform objectB; // ����B��Transform
    public TextMeshProUGUI textMesh; // TMP���

    public string goodText = " "; // �ı�
    public string greatText = " "; // �ı�
    public string defaultText = " "; // Ĭ���ı�

    public float goodDistance = 0.8f; // �õľ�����ֵ
    public float greatDistance = 1.8f; // ͦ�õľ�����ֵ

    public Button specifiedButton; // Ҫ�������õ�ָ����ť

    void Update()
    {
        // ��������A������B֮��ľ���
        float distance = Vector3.Distance(objectA.position, objectB.position);

        // ���ݾ�������TMP������
        if (distance < goodDistance)
        {
            textMesh.text = goodText;

            // ���ָ����ť�Ƿ���ڲ�����
            if (specifiedButton != null)
            {
                specifiedButton.gameObject.SetActive(true);
            }
        }
        else if (distance >= goodDistance && distance <= greatDistance)
        {
            textMesh.text = greatText;

            // ���ָ����ť�Ƿ���ڲ�����
            if (specifiedButton != null)
            {
                specifiedButton.gameObject.SetActive(false);
            }
        }
        else
        {
            textMesh.text = defaultText;

            // ���ָ����ť�Ƿ���ڲ�����
            if (specifiedButton != null)
            {
                specifiedButton.gameObject.SetActive(false);
            }
        }
    }
}