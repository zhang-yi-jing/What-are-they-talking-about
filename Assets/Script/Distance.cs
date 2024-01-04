using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform targetObject; // ��Ҫ�������Ŀ������
    public GameObject uiObject; // ������ص�UI����
    public TMPro.TextMeshProUGUI textComponent; // UI�е��ı����

    public float maxDistance = 10f; // ������
    public float minSize = 0.5f; // ��С��С
    public float maxSize = 1.5f; // ����С
    public float minOpacity = 0.2f; // ��С͸����
    public float maxOpacity = 1f; // ���͸����

    private void Update()
    {
        // ����Ŀ��������ű���������֮��ľ���
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // ���ݾ������UI�Ĵ�С
        float normalizedDistance = Mathf.Clamp01(distance / maxDistance);
        float size = Mathf.Lerp(maxSize, minSize, normalizedDistance);

        // ����UI�����Ŵ�С
        uiObject.transform.localScale = new Vector3(size, size, size);

    }
}