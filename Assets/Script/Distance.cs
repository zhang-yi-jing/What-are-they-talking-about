using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform targetObject; // 需要检测距离的目标物体
    public GameObject uiObject; // 距离相关的UI对象
    public TMPro.TextMeshProUGUI textComponent; // UI中的文本组件

    public float maxDistance = 6f; // 最大距离
    public float minSize = 1.5f; // 最小大小
    public float maxSize = 3f; // 最大大小

    private void Update()
    {
        // 计算目标物体与脚本所在物体之间的距离
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // 根据距离计算UI的大小
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

        // 设置UI的缩放大小
        uiObject.transform.localScale = new Vector3(size, size, size);
    }
}