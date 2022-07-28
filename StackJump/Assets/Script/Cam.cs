using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Cam : MonoBehaviour
{
    public CharacterChange character;
    public GameObject[] _cam = new GameObject[8];
    // Start is called before the first frame update



    void Start()
    {
        character = FindObjectOfType<CharacterChange>();
        for (int i=0; i<7;i++)
        {
            _cam[i].SetActive(false);
        }

        _cam[character.character_type].SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
