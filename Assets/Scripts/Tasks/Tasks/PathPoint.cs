using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.UI;
using TMPro;

public class PathPoint : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer = null;
    [SerializeField] private TMP_Text pointIDText = null;
    [ReadOnly] private FollowPathTask followPathTask = null;
    private MaterialPropertyBlock materialPropertyBlock = null;
    private int pointID = 0;

    void Start()
    {
        materialPropertyBlock = new MaterialPropertyBlock();
        meshRenderer.GetPropertyBlock(materialPropertyBlock);
        materialPropertyBlock.SetColor("_Color", Color.red);
        meshRenderer.SetPropertyBlock(materialPropertyBlock);
        followPathTask.AddPathPoint(this);
    }

    private void PlayerMovedPastThisPoint()
    {
        materialPropertyBlock.SetColor("_Color", Color.green);
        meshRenderer.SetPropertyBlock(materialPropertyBlock);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");

        if (!other.CompareTag("Player"))
        {
            return;
        }

        if (followPathTask.IncreasePathIndex(pointID))
        {
            PlayerMovedPastThisPoint();
        }
    }

    private void OnValidate()
    {
        if (followPathTask == null)
        {
            followPathTask = GetComponentInParent<FollowPathTask>();
        }
    }

    public void SetPointID(int id)
    {
        pointID = id;
        pointIDText.text = pointID.ToString();
    }
}