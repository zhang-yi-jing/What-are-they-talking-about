using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTextUpdater : MonoBehaviour
{
    public Transform objectA; // 物体A的Transform
    public Transform objectB; // 物体B的Transform
    public TextMeshProUGUI textMesh; // TMP组件

    public string goodText = " "; // 文本
    public string greatText = " "; // 文本
    public string defaultText = " "; // 默认文本

    public float goodDistance = 0.8f; // 好的距离阈值
    public float greatDistance = 1.8f; // 挺好的距离阈值

    public Button specifiedButton; // 要激活或禁用的指定按钮

    void Update()
    {
        // 计算物体A和物体B之间的距离
        float distance = Vector3.Distance(objectA.position, objectB.position);

        // 根据距离设置TMP的内容
        if (distance < goodDistance)
        {
            textMesh.text = goodText;
            specifiedButton.gameObject.SetActive(true); // 激活指定按钮
        }
        else if (distance >= goodDistance && distance <= greatDistance)
        {
            textMesh.text = greatText;
            specifiedButton.gameObject.SetActive(false); // 禁用指定按钮
        }
        else
        {
            textMesh.text = defaultText;
            specifiedButton.gameObject.SetActive(false); // 禁用指定按钮
        }
    }
}