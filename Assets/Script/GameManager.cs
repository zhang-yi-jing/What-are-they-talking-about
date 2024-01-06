using UnityEngine;


public class GameManager : MonoBehaviour
{
    KeyCode pauseKey = KeyCode.B; // 暂停键
    public GameObject uiPanel; // 要打开的 UI 面板

    private bool isPaused = false; // 游戏是否已暂停

    private Inventory inventory;

    [SerializeField] private UIInventory uIInventoy;

    private void Awake()
    {
        inventory = new Inventory();
        uIInventoy.SetInventory(inventory);
    }
    void Update()
    {
        // 检测是否按下暂停键
        if (Input.GetKeyDown(pauseKey))
        {
            if (isPaused)
            {
                ResumeGame(); // 如果已暂停，则继续游戏
            }
            else
            {
                PauseGame(); // 如果未暂停，则暂停游戏
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // 停止游戏时间
        isPaused = true;
        uiPanel.SetActive(true); // 打开指定的 UI 面板
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // 恢复游戏时间
        isPaused = false;
        uiPanel.SetActive(false); // 关闭指定的 UI 面板
    }
}