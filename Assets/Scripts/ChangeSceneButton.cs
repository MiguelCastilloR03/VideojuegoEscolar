using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneButton:MonoBehaviour
{
    [SerializeField] private Button button; // Arrastra el botón desde el inspector
    [SerializeField] private string sceneName;  // El nombre de la escena a la que deseas cambiar

    void Start()
    {
        if (button != null)
        {
            button.onClick.AddListener(ChangeScene);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
