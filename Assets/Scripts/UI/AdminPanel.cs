using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class AdminPanel : MonoBehaviour
{   
    [SerializeField] private Button WinGameButton;
    [SerializeField] private Button AIMakeMoveButton;
    [SerializeField] private Button LoseGameButton;
    [SerializeField] private Button ResetGameButton;
    [SerializeField] private Button ToggleFly;
    [SerializeField] private DynamicMoveProvider moveProvider;

    // Start is called before the first frame update
    void Start()
    {
        WinGameButton.onClick.AddListener(WinGame);
        AIMakeMoveButton.onClick.AddListener(AIMakeMove);
        LoseGameButton.onClick.AddListener(LoseGame);
        ResetGameButton.onClick.AddListener(ResetGame);
        ToggleFly.onClick.AddListener(ToggleFlyMode);

    }

    private void WinGame()
    {    }

    private void AIMakeMove()
    {

    }

    private void LoseGame()
    {
    } 

    private void ResetGame()
    {
        SceneLoader.instance.LoadScene(1);
    }
    
    private void ToggleFlyMode()
    {   
        moveProvider.enableFly = !moveProvider.enableFly;
    }
    
}
