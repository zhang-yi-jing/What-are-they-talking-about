using UnityEngine;
using UnityEngine.UI;

public class ExitThisGame : MonoBehaviour
{
    private void Start()
    {
        // ��ȡ��ť���
        Button button = GetComponent<Button>();

        // ��Ӱ�ť����¼�������
        button.onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        // �ڷ����汾���˳���Ϸ
        Application.Quit();

    }
}