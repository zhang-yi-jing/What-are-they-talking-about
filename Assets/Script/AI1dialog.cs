using TMPro;
using UnityEngine;

public class TextSwitcher : MonoBehaviour
{
    public TextMeshProUGUI[] textArray; // TMP文本数组
    public float[] switchDelays; // 切换的延迟时间数组

    private int currentIndex = 0; // 当前文本的索引
    private float timer = 0f; // 计时器

    void Start()
    {
        // 设置初始文本
        SetText(currentIndex);
    }

    void Update()
    {
        // 更新计时器
        timer += Time.deltaTime;

        // 判断是否达到切换的延迟时间
        if (timer >= switchDelays[currentIndex])
        {
            // 切换到下一条文本
            NextText();
            // 重置计时器
            timer = 0f;
        }
    }

    // 切换到下一条文本
    void NextText()
    {
        currentIndex++;
        // 如果超出文本数组的长度，回到数组开头
        if (currentIndex >= textArray.Length)
        {
            currentIndex = 0;
        }

        // 设置当前文本
        SetText(currentIndex);
    }

    // 设置文本内容
    void SetText(int index)
    {
        // 禁用之前的文本
        for (int i = 0; i < textArray.Length; i++)
        {
            textArray[i].gameObject.SetActive(false);
        }

        // 激活当前文本
        textArray[index].gameObject.SetActive(true);
    }
}