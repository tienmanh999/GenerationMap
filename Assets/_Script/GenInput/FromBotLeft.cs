using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "SO/Generation Input/Bot Left")]
public class FromBotLeft : GenerationMode
{
    public override void GenerationTiles(GameObject[] tiles,int y, int x, float cellSize, int index)
    {
        posX = 0f;
        posY = 0f;
        startPos = Camera.main.ScreenToWorldPoint(new Vector3(posX, posY, 0f));

        Vector3 pos = new Vector3(startPos.x + cellSize * x + cellSize / 2,
                                     startPos.y + cellSize * y + cellSize / 2);

        MonoBehaviour.Instantiate(tiles[index], pos, Quaternion.identity);
    }
}
