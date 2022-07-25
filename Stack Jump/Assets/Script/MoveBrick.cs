using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveBrick : MonoBehaviour
{
    public BrickManager _brickmanager;
    public float speed;
    private Transform _brick;

    private bool triger = false;
    private bool triger2 = true;
    public float beforeY;

    // Start is called before the first frame update
    void Start()
    {
        _brick = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float beforeX = _brick.position.x;
        float time = Time.deltaTime;

        Vector2 newposition;


        if (beforeX < -3)
            triger = true;

        if (beforeX > 4)
            triger = false;

        if (triger2)
        {
            if (triger == false)
            {
                newposition = new Vector2(beforeX - time * speed, beforeY);

            }
            else
            {
                newposition = new Vector2(beforeX + time * speed, beforeY);

            }
            _brick.transform.position = newposition;
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        triger2 = false;
        _brickmanager.ShowNextBrick();
    }



}
