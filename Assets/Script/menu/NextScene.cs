using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public Button button;
    public Canvas canvas;
    public GameObject prefab;
    public float fadeDuration = 1f;
    public string nextSceneName;

    private GameObject instantiatedPrefab;
    private Image imageComponent;
    private float currentTransparency;
    private bool isFadeComplete = false;

    private void Start()
    {
        button.onClick.AddListener(OnButtonClick);
        currentTransparency = 0f;
    }

    private void Update()
    {
        if (isFadeComplete)
        {
            LoadNextScene();
        }
    }

    private void OnButtonClick()
    {
        instantiatedPrefab = Instantiate(prefab, canvas.transform);
        imageComponent = instantiatedPrefab.GetComponent<Image>();
        StartCoroutine(FadeInImage());
    }

    private System.Collections.IEnumerator FadeInImage()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeDuration)
        {
            currentTransparency = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            UpdateImageTransparency();

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        isFadeComplete = true;
    }

    private void UpdateImageTransparency()
    {
        Color color = imageComponent.color;
        color.a = currentTransparency;
        imageComponent.color = color;
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}