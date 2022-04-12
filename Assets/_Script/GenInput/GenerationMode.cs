using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenerationMode : ScriptableObject
{
    protected float posX, posY;
    protected Vector3 startPos;
    public abstract void GenerationTiles(GameObject[] tiles,int y, int x, float cellSize, int index);
}
