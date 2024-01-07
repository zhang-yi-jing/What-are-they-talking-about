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
        // ͸���Ƚ���
        currentTransparency = Mathf.MoveTowards(currentTransparency, endTransparency, transitionSpeed * Time.deltaTime);
        UpdateImageTransparency();

        // �жϽ����Ƿ����
        if (currentTransparency <= endTransparency)
        {
            // ������ɺ�ִ�еĲ���
            OnTransitionComplete();

            // ������Ϸ����
            Destroy(gameObject);
        }
    }

    private void UpdateImageTransparency()
    {
        // ����ͼƬ͸����
        Color color = imageComponent.color;
        color.a = currentTransparency;
        imageComponent.color = color;
    }

    private void OnTransitionComplete()
    {
        // ������ɺ�ִ�еĲ���
        Debug.Log("Transition complete!");
    }
}