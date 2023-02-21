using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UIController 
{
    private static Dictionary<string, UIPanelInterface> panels = new Dictionary<string, UIPanelInterface>();
    private static UIPanelInterface currentPanel = null;

    public static void RegisterPanel(UIPanelInterface panel)
    {
        if (panels.ContainsKey(panel.GetPanelName()))
        {
            Debug.LogError("Panel with name " + panel.GetPanelName() + " already exists");
            return;
        }
        panels.Add(panel.GetPanelName(), panel);
    }

    public static void UnregisterPanel(UIPanelInterface panel)
    {
        if (!panels.ContainsKey(panel.GetPanelName()))
        {
            Debug.LogError("Panel with name " + panel.GetPanelName() + " does not exist");
            return;
        }
        panels.Remove(panel.GetPanelName());
    }


    public static void ShowPanel(string panelName)
    {
        if (!panels.ContainsKey(panelName))
        {
            Debug.LogError("Panel with name " + panelName + " does not exist");
            return;
        }
        if (currentPanel != null)
        {
            currentPanel.Hide();
        }
        currentPanel = panels[panelName];
        currentPanel.Show();
    }

    public static void ShowMainMenu()
    {
        ShowPanel("MainMenu");
    }

    public static void ShowOptions()
    {
        ShowPanel("Options");
    }

    public static void OnSceneChange()
    {
        if (currentPanel != null)
        {
            currentPanel = null;
        }

        panels.Clear();
    }
}
