using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class PathPoint : MonoBehaviour
{
    [SerializeField] private MeshRenderer meshRenderer = null;
    [ReadOnly] private FollowPathTask followPathTask = null;
    private MaterialPropertyBlock materialPropertyBlock = null;



    void Start()
    {
        materialPropertyBlock = new MaterialPropertyBlock();
        meshRenderer.GetPropertyBlock(materialPropertyBlock);
        materialPropertyBlock.SetColor("_Color", Color.red);
        meshRenderer.SetPropertyBlock(materialPropertyBlock);
    }

    private void PlayerMovedPastThisPoint()
    {
       materialPropertyBlock.SetColor("_Color", Color.green);
       meshRenderer.SetPropertyBlock(materialPropertyBlock);
    }

    private void OnValidate()
    {
        if (followPathTask == null)
        {
            followPathTask = GetComponentInParent<FollowPathTask>();
        }
    }
}
