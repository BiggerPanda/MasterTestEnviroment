using UnityEngine;
using NaughtyAttributes;

public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] private PuzzleTypeDeterminator puzzleTypeDeterminator = null;
    private PuzzlePieceType currentPuzzlePieceType = PuzzlePieceType.Triangle;
    private int currentPuzzlePieceIndex = 0;


    public bool IsInCorrectPosition()
    {
        return currentPuzzlePieceType == puzzleTypeDeterminator.PuzzlePieceType;
    }

    public void OnInteraction()
    {
        currentPuzzlePieceIndex++;

        if (currentPuzzlePieceIndex > 3)
        {
            currentPuzzlePieceIndex = 0;
        }

        currentPuzzlePieceType = (PuzzlePieceType)currentPuzzlePieceIndex;

        gameObject.transform.rotation = Quaternion.Euler(0, currentPuzzlePieceIndex * 90, 0);
    }

#if UNITY_EDITOR
    [Button]
    private void TestInteraction()
    {
        OnInteraction();
    }
#endif
}