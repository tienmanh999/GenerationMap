using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "SO/Generation Logic/Basic Logic")]
public class BasicLogic : GenerationLogic
{
    public override void Init(GameObject[] tiles,string[] data, int w, int h, float cellSize)
    {
        for (int y = 0; y < h; y++)
        {
            char[] tileIndex = data[y].ToCharArray();
            for (int x = 0; x < w; x++)
            {
                int index = int.Parse(tileIndex[x].ToString());
                mode.GenerationTiles(tiles,y, x, cellSize, index);
            }
        }
    }
}
