using UnityEngine;
[CreateAssetMenu(menuName = "SO/Generation Input/Top Left")]
public class FromTopLeft : GenerationMode
{

    public override void GenerationTiles(GameObject[] tiles, int y, int x, float cellSize, int index)
    {
        posX = 0f;
        posY = Screen.height;
        startPos = Camera.main.ScreenToWorldPoint(new Vector3(posX, posY, 0f));

        Vector3 pos = new Vector3(startPos.x + cellSize * x + cellSize / 2,
                                      startPos.y - cellSize * y - cellSize / 2);

        MonoBehaviour.Instantiate(tiles[index], pos, Quaternion.identity);
    }
}
