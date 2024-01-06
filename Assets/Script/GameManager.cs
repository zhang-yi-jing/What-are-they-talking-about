using UnityEngine;


public class GameManager : MonoBehaviour
{
    KeyCode pauseKey = KeyCode.B; // ��ͣ��
    public GameObject uiPanel; // Ҫ�򿪵� UI ���

    private bool isPaused = false; // ��Ϸ�Ƿ�����ͣ

    private Inventory inventory;

    [SerializeField] private UIInventory uIInventoy;

    private void Awake()
    {
        inventory = new Inventory();
        uIInventoy.SetInventory(inventory);
    }
    void Update()
    {
        // ����Ƿ�����ͣ��
        if (Input.GetKeyDown(pauseKey))
        {
            if (isPaused)
            {
                ResumeGame(); // �������ͣ���������Ϸ
            }
            else
            {
                PauseGame(); // ���δ��ͣ������ͣ��Ϸ
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // ֹͣ��Ϸʱ��
        isPaused = true;
        uiPanel.SetActive(true); // ��ָ���� UI ���
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // �ָ���Ϸʱ��
        isPaused = false;
        uiPanel.SetActive(false); // �ر�ָ���� UI ���
    }
}