using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CharacterChange character;
    public BrickManager _brickManager;
    public TextMeshProUGUI ScoreText;
    public GameObject _gameoverImage;
    public GameObject _gameoverText;
    public AudioSource background;

    public GameObject DontDestory;



    // Start is called before the first frame update
    void Start()
    {
        //DontDestory = FindObjectOfType<CharacterChange>();
        character = FindObjectOfType<CharacterChange>();
        background.Play();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + _brickManager.score;

        if(_brickManager._player[character.character_type].isDead)
        {
            
            background.Pause();
            _gameoverImage.SetActive(true);
            _gameoverText.SetActive(true);
            
            if(Input.GetMouseButtonDown(1))
            {
                Destroy(GameObject.FindWithTag("Finish"));
                SceneManager.LoadScene(0);
               // Destroy(GameObject.FindWithTag("Fisish"));
                //GameObject.FindWithTag("Finish");
            }
        }
    }
}
