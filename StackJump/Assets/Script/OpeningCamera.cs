using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCamera : MonoBehaviour
{
    private Transform transform;
    private float beforeX;
    private bool triger = false;
    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
        beforeX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        beforeX = transform.position.x;

        if (beforeX < -10)
            triger = true;

        if (beforeX > 10)
            triger = false;


        if (triger) 
        
            transform.position = new Vector3(beforeX + Time.deltaTime * 5,3, -10);

        else
            transform.position = new Vector3(beforeX - Time.deltaTime * 5, 3, -10);

    }
}
