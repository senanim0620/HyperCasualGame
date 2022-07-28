using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Transform _cameratransform;
    private float beforeY;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        _cameratransform = GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        beforeY = _cameratransform.transform.position.y;
        float time = Time.deltaTime;

        Vector3 newposition = new(0, beforeY+ time * speed, -3);
        _cameratransform.transform.position = newposition;


    }



}

