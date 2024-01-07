using UnityEngine;
using UnityEngine.UI;

public class BC : MonoBehaviour
{
    public GameObject prefabToAdd;
    public Transform parentObject;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();

        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
    }

    private void OnClick()
    {
        if (prefabToAdd != null && parentObject != null)
        {
            GameObject newObject = Instantiate(prefabToAdd, parentObject);
        }

        Destroy(gameObject);
    }
}