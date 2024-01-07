using UnityEngine;
using UnityEngine.UI;

public class ExitThisGame : MonoBehaviour
{
    private void Start()
    {
        // 获取按钮组件
        Button button = GetComponent<Button>();

        // 添加按钮点击事件监听器
        button.onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        // 在发布版本中退出游戏
        Application.Quit();

    }
}