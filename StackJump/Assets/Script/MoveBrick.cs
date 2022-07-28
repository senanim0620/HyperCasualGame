using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveBrick : MonoBehaviour
{
    public PlayerController player;
    public BrickManager _brickmanager;
    public float speed =3;
    private Transform _brick;

    private bool triger = false;
    public bool triger2 = true;
    public float beforeY;
    public float beforeX;

    private int LeftRight = 0;

    // Start is called before the first frame update
    void Awake()
    {
        _brick = GetComponent<Transform>();
        beforeX = _brick.position.x;

    }

    // Update is called once per frame
    void Update()
    {
         beforeX = _brick.position.x;
        float time = Time.deltaTime;

        Vector2 newposition;


        if (beforeX < -3)
            triger = true;

        if (beforeX > 4)
            triger = false;

        if (triger2)
        {
            if (_brickmanager.triger1 == true)
            {
                LeftRight = Random.Range(0, 2);
                speed = Random.Range((float)2.0, (float)4.0);

                if(LeftRight ==1)
                {
                    beforeX = -3;
                    _brickmanager.triger1 = false;
                }

                else
                {
                    beforeX = 4;
                    _brickmanager.triger1 = false;
                }

            }

            if (triger == false)
            {
                newposition = new Vector2((beforeX - time * speed), beforeY);

            }
            else
            {
                newposition = new Vector2((beforeX + time * speed), beforeY);

            }
            _brick.transform.position = newposition;
        }



    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag =="Player")
        {
            triger2 = false; // 움직임을 멈추고
            Debug.Log(collision.contacts[0].normal.y);

            if (collision.contacts[0].normal.y >= 0f)
            {
                return;
            }
            else

                _brickmanager.ShowNextBrick();
        }
            
    }



}
