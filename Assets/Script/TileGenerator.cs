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

    private void Start()
    {
        //オブジェクトを縦横に配置
        for(int row = 0; row < rowCount; row++)
        {
            for(int col =0; col < columnCount; col++)
            {
                Vector3 position = new Vector3(col,row,0);
                GameObject tile = Instantiate(objectPrefab,position,Quaternion.identity);
                tile.transform.parent = transform;
            }
        }
    }
}