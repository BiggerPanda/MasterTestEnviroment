using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsPanel : MonoBehaviour,UIPanelInterface
{
    [SerializeField] private Button backButton = null;
    // Start is called before the first frame update
    private void Awake()
    {
        Register();
    }

    // Update is called once per frame
    private void Start()
    {
        Hide();
    }

    private void OnEnable()
    {
        backButton.onClick.AddListener(BackButtonClicked);
    }

    private void OnDisable()
    {
        backButton.onClick.RemoveListener(BackButtonClicked);
    }

    private void OnDestroy()
    {
        Unregister();
    }

    public void Unregister()
    {
        UIController.UnregisterPanel(this);
    }

    private void BackButtonClicked()
    {
        UIController.ShowMainMenu();
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
        return "Options";
    }
}
