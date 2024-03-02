using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class ResetCamera : MonoBehaviour
{
    Transform tf;
    Camera cam;

    float center_x;
    float center_y;

    [SerializeField] private TileMapGenerator _TileMapGenerator;

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>();
        cam = this.gameObject.GetComponent<Camera>();

        center_x = (float)_TileMapGenerator.rowCount / 2.0f;
        center_y = (float)_TileMapGenerator.columnCount / 2.0f;

        tf.position = new Vector3(center_x,center_y,-10.0f);
    }
}
