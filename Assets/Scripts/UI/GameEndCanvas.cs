using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameEndCanvas : MonoBehaviour
{
    [SerializeField] private TMP_Text textField = null;
    [SerializeField] private Canvas canvas = null;
    [SerializeField] private Button returnButton = null;

    private void Start()

    {
        returnButton.onClick.AddListener(ReturnToMenu);

    }

    private void DisplayWindow()
    {

    }

    private void DisplayWin()
    {
        canvas.enabled = true;
        textField.text = "You Won";
    }

    private void DisplayLose()
    {
        canvas.enabled = true;
        textField.text = "You Lost";
    }

    private void DisplayDraw()
    {
        canvas.enabled = true;
        textField.text = "Draw";
    }

    private void ReturnToMenu()
    {
        SceneLoader.instance.LoadMenu();
    }
}
