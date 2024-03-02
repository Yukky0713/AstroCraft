using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapGenerator : MonoBehaviour
{
    [Header("タイルマップ")]
    [SerializeField] private Tilemap tilemap;
    [SerializeField] private TileBase tile;

    [Header("タイル設置サイズ")]
    [SerializeField] private int rowCount = 10;
    [SerializeField] private int columnCount = 10;

    void Start()
    {
        //オブジェクトを縦横に配置
        for(int row = 0; row < rowCount; row++)
        {
            for(int col =0; col < columnCount; col++)
            {
                Vector3Int position = new Vector3Int(col,row, 0);
                tilemap.SetTile(position, tile);
            }
        }
    }
}