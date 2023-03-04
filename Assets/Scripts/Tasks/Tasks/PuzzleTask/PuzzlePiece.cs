using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] private PuzzleTypeDeterminator puzzleTypeDeterminator = null;
    private PuzzlePieceType currentPuzzlePieceType = PuzzlePieceType.Triangle;
    [SerializeField,ReadOnly]private int currentPuzzlePieceIndex = 0;
    
    private void Start()
    {
        //randomize the starting position but different than the correct position
        currentPuzzlePieceIndex = Random.Range(0, 4);
        rotateObjectBasedOnIndex(currentPuzzlePieceIndex);
        currentPuzzlePieceType = (PuzzlePieceType)currentPuzzlePieceIndex;
    }

    public bool IsInCorrectPosition()
    {
        return currentPuzzlePieceType == puzzleTypeDeterminator.PuzzlePieceType;
    }

    public void OnInteraction() // used by XRInteractionComponent
    {
        currentPuzzlePieceIndex++;

        if (currentPuzzlePieceIndex > 3)
        {
            currentPuzzlePieceIndex = 0;
        }

        currentPuzzlePieceType = (PuzzlePieceType)currentPuzzlePieceIndex;

        rotateObjectBasedOnIndex(currentPuzzlePieceIndex);
    }

    private void rotateObjectBasedOnIndex(int index)
    {
        gameObject.transform.DOLocalRotate(new Vector3(0, index * 90, 0), 0.1f, RotateMode.Fast);
    }
    
#if UNITY_EDITOR
    [Button]
    private void TestInteraction()
    {
        OnInteraction();
    }
#endif
}