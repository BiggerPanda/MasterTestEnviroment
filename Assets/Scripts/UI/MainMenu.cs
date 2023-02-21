using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour,UIPanelInterface
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    [SerializeField] private Button optionsButton;
    // Start is called before the first frame update

    private void Awake()
    {
        Register();
    }

    void Start()
    {
        UIController.ShowMainMenu();
    }

    private void OnEnable()
    {
        playButton.onClick.AddListener(() => SceneLoader.instance.LoadScene(1));
        quitButton.onClick.AddListener(() => SceneLoader.instance.QuitGame());
        optionsButton.onClick.AddListener(() => UIController.ShowOptions());
    }

    private void OnDisable()
    {
        playButton.onClick.RemoveAllListeners();
        quitButton.onClick.RemoveAllListeners();
        optionsButton.onClick.RemoveAllListeners();
    }

    private void OnDestroy()
    {
        Unregister();
    }

    public void Unregister()
    {
        UIController.UnregisterPanel(this);
    }


    public void Register()
    {
        UIController.RegisterPanel(this);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public string GetPanelName()
    {
        return "MainMenu";
    }
}
