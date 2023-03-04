using UnityEngine;

public enum PuzzlePieceType
{
   
    Square,
    Triangle,
    Arch,
    Torus,
}

[ExecuteInEditMode]
public class PuzzleTypeDeterminator : MonoBehaviour
{
    [SerializeField] private PuzzlePieceType puzzlePieceType = PuzzlePieceType.Triangle;
    [SerializeField] private GameObject triangle = null;
    [SerializeField] private GameObject square = null;
    [SerializeField] private GameObject arch = null;
    [SerializeField] private GameObject torus = null;
    public PuzzlePieceType PuzzlePieceType { get; private set; }

    private void Start()
    {
        SetPuzzlePieceType(puzzlePieceType);
    }

    private void SetPuzzlePieceType(PuzzlePieceType _puzzlePieceType)
    {
        switch (_puzzlePieceType)
        {
            case PuzzlePieceType.Triangle:
                triangle.SetActive(true);
                square.SetActive(false);
                arch.SetActive(false);
                torus.SetActive(false);
                break;
            case PuzzlePieceType.Square:
                triangle.SetActive(false);
                square.SetActive(true);
                arch.SetActive(false);
                torus.SetActive(false);
                break;
            case PuzzlePieceType.Arch:
                triangle.SetActive(false);
                square.SetActive(false);
                arch.SetActive(true);
                torus.SetActive(false);
                break;
            case PuzzlePieceType.Torus:
                triangle.SetActive(false);
                square.SetActive(false);
                arch.SetActive(false);
                torus.SetActive(true);
                break;
            default:
                break;
        }

        PuzzlePieceType = _puzzlePieceType;
    }
    
    private void Update()
    {
        SetPuzzlePieceType(puzzlePieceType);
    }
}