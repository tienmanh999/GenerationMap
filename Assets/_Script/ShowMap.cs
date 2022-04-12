using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GenerationTileMap;
public class ShowMap : MonoBehaviour
{
    public GameObject[] tiles;
    public GenMode mode;
    public GenerationLogic logic;
    private void Start()
    {
        TextAsset rawData = Resources.Load("map") as TextAsset;
        //Generation.ShowMap(rawData, tiles, mode);
        Generation.ShowMap(rawData, tiles, logic);
    }
}
