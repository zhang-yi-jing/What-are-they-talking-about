using UnityEngine;
using UnityEngine.UI;

public class ImageTransparencyController : MonoBehaviour
{
    public float startTransparency = 1f;
    public float endTransparency = 0.01f;
    public float transitionSpeed = 1f;

    private float currentTransparency;
    private Image imageComponent;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        currentTransparency = startTransparency;
    }

    private void Update()
    {
        // 透明度渐变
        currentTransparency = Mathf.MoveTowards(currentTransparency, endTransparency, transitionSpeed * Time.deltaTime);
        UpdateImageTransparency();

        // 判断渐变是否完成
        if (currentTransparency <= endTransparency)
        {
            // 渐变完成后执行的操作
            OnTransitionComplete();

            // 销毁游戏对象
            Destroy(gameObject);
        }
    }

    private void UpdateImageTransparency()
    {
        // 更新图片透明度
        Color color = imageComponent.color;
        color.a = currentTransparency;
        imageComponent.color = color;
    }

    private void OnTransitionComplete()
    {
        // 渐变完成后执行的操作
        Debug.Log("Transition complete!");
    }
}