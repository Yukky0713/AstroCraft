using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    Transform tf; //Main CameraのTransform
    Camera cam; //Main CameraのCamera
    
    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>();
        cam = this.gameObject.GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tf.position = tf.position + new Vector3(0.0f,1.0f,0.0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            tf.position = tf.position + new Vector3(0.0f,-1.0f,0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            tf.position = tf.position + new Vector3(-1.0f,0.0f,0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            tf.position = tf.position + new Vector3(1.0f,0.0f,0.0f);
        }
    }
}