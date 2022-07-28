using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerType : MonoBehaviour
{
    public CharacterChange character;

    public GameObject[] _player = new GameObject[7];

    // Start is called before the first frame update


    void Start()
    {
        character = FindObjectOfType<CharacterChange>();
        for (int i = 0; i <= 7; i++)
            _player[i].SetActive(false);

        _player[character.character_type].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
