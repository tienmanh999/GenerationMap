using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenerationLogic : ScriptableObject
{
    [SerializeField] protected GenerationMode mode;
    public abstract void Init(GameObject[] tiles,string[] data, int w, int h, float cellSize);
   
}
