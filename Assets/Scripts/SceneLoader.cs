using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    [SerializeField] private SceneScriptableList data;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(int scene)
    {
        UIController.OnSceneChange();
        SceneManager.LoadScene(data.findScene(scene).sceneIndex, LoadSceneMode.Single);
    }

    public void LoadMenu()
    {
        UIController.OnSceneChange();
        SceneManager.LoadScene(data.findScene(0).sceneIndex, LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
