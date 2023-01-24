using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilePainter : MonoBehaviour
{
    public RuleTile myRuleTile;
    public Tilemap myTilemap;

    public Vector2Int size;

    [ContextMenu("Paint")]

    public void Paint()
    {
         myTilemap.DeleteCells(new Vector3Int(0, 0, 0), new Vector3Int(myTilemap.size.x, myTilemap.size.y, 0));
        

        for(int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                if (Random.Range(0f,1f)> 0.7)
                myTilemap.SetTile(new Vector3Int(i, j, 0), myRuleTile);
            }
        }
    }
}
