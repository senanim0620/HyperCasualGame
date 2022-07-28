using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickManager : MonoBehaviour
{
    public CharacterChange character;

    public PlayerController[] _player = new PlayerController[7];

    public int layer;
    public float raiseY;
    public bool triger1 = false;
    public int score = 0;

    public GameObject[] _bricks = new GameObject[8];


    void Start()
    {
        character = FindObjectOfType<CharacterChange>();
        // _player = type._player[type.character.character_type];
        raiseY = (float)0;
        layer = 0;
        for (int i = 0; i < 8; i++) 
        {
            _bricks[i].SetActive(false);
        }
        _bricks[0].GetComponent<MoveBrick>().beforeY = raiseY;
        _bricks[0].SetActive(true);
    }




    // ��... ��� MoveBrick���� �ε��� ������ �ҷ���
    public void ShowNextBrick()
    {
        score++;
        if (_player[character.character_type].isDead)
            return;

        layer = (layer + 1) % 7;
            
        if(_bricks[layer].activeSelf == true) // �̹� ���� ������
        {
            Debug.Log("��������");
            triger1 = true;
            _bricks[layer].GetComponent<MoveBrick>().triger2 = true;
            _bricks[layer].GetComponent<MoveBrick>().beforeX = -3;
            raiseY += 0.45f;
            _bricks[layer].GetComponent<MoveBrick>().beforeY = raiseY;

        }

        else // �ѹ��� ���� �ִ� ���� ��������
        {
            raiseY += 0.45f;
            _bricks[layer].GetComponent<MoveBrick>().beforeY = raiseY;
            _bricks[layer].SetActive(true); // �׳� Ų��.


        }
        


    }
}
