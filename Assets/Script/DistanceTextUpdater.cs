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
            specifiedButton.gameObject.SetActive(true); // ����ָ����ť
        }
        else if (distance >= goodDistance && distance <= greatDistance)
        {
            textMesh.text = greatText;
            specifiedButton.gameObject.SetActive(false); // ����ָ����ť
        }
        else
        {
            textMesh.text = defaultText;
            specifiedButton.gameObject.SetActive(false); // ����ָ����ť
        }
    }
}