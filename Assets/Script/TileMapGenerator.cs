using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapGenerator : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] Tile blockTile;
    [SerializeField] Tile fieldTile;

    void Start()
    {
        StartCoroutine(SetTile());
    }

    IEnumerator SetTile()
    {
        for (int z = 0; z < 5; z++)
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    tilemap.SetTile(new Vector3Int(x, y, z * 2), z % 2 == 0 ? blockTile : fieldTile);
                    yield return new WaitForEndOfFrame();
                }
            }
        }
    }
}
