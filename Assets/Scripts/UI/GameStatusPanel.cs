using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatusPanel : MonoBehaviour
{

    [SerializeField] private TMP_Text turnText = null;
    [SerializeField] private TMP_Text BlackDeadAmount = null;
    [SerializeField] private TMP_Text WhiteDeadAmount = null;
    public bool handInfo = false;

    private void Start()
    {

    }

    public void UpdateText()
    {

    }
}
