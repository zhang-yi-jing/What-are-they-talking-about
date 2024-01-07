using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform targetObject; // ��Ҫ�������Ŀ������
    public GameObject uiObject; // ������ص�UI����
    public TMPro.TextMeshProUGUI textComponent; // UI�е��ı����

    public float maxDistance = 6f; // ������
    public float minSize = 1.5f; // ��С��С
    public float maxSize = 3f; // ����С

    private void Update()
    {
        // ����Ŀ��������ű���������֮��ľ���
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // ���ݾ������UI�Ĵ�С
        float size = 0f;
        if (distance > maxDistance)
        {
            size = 0f;
        }
        else if (distance >= 2f && distance <= 3f)
        {
            size = minSize;
        }
        else if (distance >= 1f && distance < 2f)
        {
            size = 0.6f;
        }
        else if (distance < 1f)
        {
            size = maxSize;
        }

        // ����UI�����Ŵ�С
        uiObject.transform.localScale = new Vector3(size, size, size);
    }
}