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
        for (int i = 0; i < 8; i++) // ÀÌ°ÔµÇ³×... 
        {
            _bricks[i].SetActive(false);
        }
        _bricks[0].GetComponent<MoveBrick>().beforeY = raiseY;
        _bricks[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }



    // ±×... ¾ê´Â MoveBrick¿¡¼­ ºÎµúÈú ¶§¸¶´Ù ºÒ·ÁÁü
    public void ShowNextBrick()
    {
            raiseY += 0.44f;
            layer = (layer + 1) % 7;
            _bricks[layer ].GetComponent<MoveBrick>().beforeY = raiseY;
            _bricks[layer].SetActive(true);

    }
}
