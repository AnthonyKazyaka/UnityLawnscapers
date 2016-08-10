﻿using UnityEngine;
using UnityEditor;
using System.Collections;

public class PuzzleGeneratorMenuOptions : EditorWindow
{
    [MenuItem("Puzzle Generator/Test")]
    private static void MenuCreatePuzzle()
    {
        GameObject newObject = new GameObject("Test Tiles");
        newObject.AddComponent<PuzzleGenerator>();

        newObject.GetComponent<PuzzleGenerator>().GeneratePuzzle();
        Undo.RegisterCreatedObjectUndo(newObject, "Create " + newObject.name);
    }


}