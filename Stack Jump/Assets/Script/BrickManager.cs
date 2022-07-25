using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickManager : MonoBehaviour
{
    public int layer;
    public float raiseY;

    public GameObject[] _bricks = new GameObject[8];

    // Start is called before the first frame update
    void Start()
    {
        raiseY = (float)0;
        layer = 0;
        for (int i = 0; i < 8; i++) // 이게되네... 
        {
            _bricks[i].SetActive(false);
        }
        _bricks[0].GetComponent<MoveBrick>().beforeY = raiseY;
        _bricks[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (layer == 7)
        {
            _bricks[layer].SetActive(false);
            layer = 0;

        }
        else
        {


           /* if (_bricks[layer].GetComponent<MoveBrick>().triger2)
            {
                raiseY += 0.436f;

                // _bricks[layer + 1].GetComponent<MoveBrick>().beforeY = raiseY;
                _bricks[layer].SetActive(false);
                _bricks[layer + 1].SetActive(true);
                _bricks[layer].GetComponent<MoveBrick>().triger2 = false; // 재사용을 위해 false로 돌려둔다.
                layer++;

            }*/
        }

    }



    public void ShowNextBrick()
    {
        raiseY += 0.44f;
        layer++;
        _bricks[layer].GetComponent<MoveBrick>().beforeY = raiseY;
        _bricks[layer].SetActive(true);
    }
}
