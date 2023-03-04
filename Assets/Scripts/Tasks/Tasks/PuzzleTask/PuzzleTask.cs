using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class PuzzleTask : Task
{
    [SerializeField,ReadOnly(true)] private List<PuzzlePiece> puzzlePieces = new List<PuzzlePiece>();
    [SerializeField] private GameObject puzzlePieceContainer = null;

    private void Awake()
    {
        puzzlePieces = new List<PuzzlePiece>(puzzlePieceContainer.GetComponentsInChildren<PuzzlePiece>());
    }
    

    protected override void checkIfIsComplete()
    {
        foreach (PuzzlePiece piece in puzzlePieces)
        {
            if(piece.IsInCorrectPosition() == false)
            {
                return;
            }
            
            isComplete = true;
        }
    }
}
