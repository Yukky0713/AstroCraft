using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// オブジェクトを縦横に配置するスクリプト
/// </summary>
public class TileGenerator : MonoBehaviour
{
    //クローンされるオブジェクト
    [SerializeField] private GameObject objectPrefab;
    //オブジェクト数
    [SerializeField] private int rowCount = 10;
    [SerializeField] private int columnCount = 10;

    private float center_x;
    private float center_y;

    private void Start()
    {
        //タイル生成の開始地点
        center_x = -(float)rowCount / 2.0f + 0.5f;
        center_y = -(float)columnCount / 2.0f + 0.5f;

        //オブジェクトを縦横に配置
        for(int row = 0; row < rowCount; row++)
        {
            for(int col =0; col < columnCount; col++)
            {
                Vector3 position = new Vector3(center_x + (float)col, center_y + (float)row, 0);
                GameObject tile = Instantiate(objectPrefab,position,Quaternion.identity);
                tile.transform.parent = transform;
            }
        }
    }
}