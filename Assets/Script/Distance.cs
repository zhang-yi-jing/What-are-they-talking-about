using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform targetObject; // 需要检测距离的目标物体
    public GameObject uiObject; // 距离相关的UI对象
    public TMPro.TextMeshProUGUI textComponent; // UI中的文本组件

    public float maxDistance = 10f; // 最大距离
    public float minSize = 0.5f; // 最小大小
    public float maxSize = 1.5f; // 最大大小
    public float minOpacity = 0.2f; // 最小透明度
    public float maxOpacity = 1f; // 最大透明度

    private void Update()
    {
        // 计算目标物体与脚本所在物体之间的距离
        float distance = Vector3.Distance(transform.position, targetObject.position);

        // 根据距离计算UI的大小
        float normalizedDistance = Mathf.Clamp01(distance / maxDistance);
        float size = Mathf.Lerp(maxSize, minSize, normalizedDistance);

        // 设置UI的缩放大小
        uiObject.transform.localScale = new Vector3(size, size, size);

    }
}