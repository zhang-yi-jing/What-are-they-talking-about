using TMPro;
using UnityEngine;

public class TextSwitcher : MonoBehaviour
{
    public TextMeshProUGUI[] textArray; // TMP�ı�����
    public float[] switchDelays; // �л����ӳ�ʱ������

    private int currentIndex = 0; // ��ǰ�ı�������
    private float timer = 0f; // ��ʱ��

    void Start()
    {
        // ���ó�ʼ�ı�
        SetText(currentIndex);
    }

    void Update()
    {
        // ���¼�ʱ��
        timer += Time.deltaTime;

        // �ж��Ƿ�ﵽ�л����ӳ�ʱ��
        if (timer >= switchDelays[currentIndex])
        {
            // �л�����һ���ı�
            NextText();
            // ���ü�ʱ��
            timer = 0f;
        }
    }

    // �л�����һ���ı�
    void NextText()
    {
        currentIndex++;
        // ��������ı�����ĳ��ȣ��ص����鿪ͷ
        if (currentIndex >= textArray.Length)
        {
            currentIndex = 0;
        }

        // ���õ�ǰ�ı�
        SetText(currentIndex);
    }

    // �����ı�����
    void SetText(int index)
    {
        // ����֮ǰ���ı�
        for (int i = 0; i < textArray.Length; i++)
        {
            textArray[i].gameObject.SetActive(false);
        }

        // ���ǰ�ı�
        textArray[index].gameObject.SetActive(true);
    }
}