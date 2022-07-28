using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterChange : MonoBehaviour
{
    public GameObject stageNumObject;
    public int character_type = 0;
    public bool triger4 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnClickKing()
    {
        Debug.Log("킹슬라임 눌림");
        DontDestroyOnLoad(stageNumObject);
        character_type = 0;
        triger4 = true;
    }

    public void OnClickLeft()
    {
        Debug.Log("리프슬라임 눌림");
        
        character_type = 6;
        DontDestroyOnLoad(stageNumObject);
        triger4 = true;
    }

    public void OnClickMetal()
    {
        Debug.Log("메탈슬라임 눌림"); 
        DontDestroyOnLoad(stageNumObject);       
        character_type = 2;
        triger4 = true;
    }
    public void OnClickMokoko()
    {
        Debug.Log("모코코 슬라임 눌림");
        DontDestroyOnLoad(stageNumObject);
        character_type = 6;
        triger4 = true;
    }

    public void OnClickPlane()
    {
        Debug.Log("플레인 슬라임 눌림");
        DontDestroyOnLoad(stageNumObject);
        character_type = 1;
        triger4 = true;
    }

    public void OnClickViking()
    {
        Debug.Log("바이킹 슬라임 눌림");
        DontDestroyOnLoad(stageNumObject);
        character_type = 3;
        triger4 = true;
    }

    public void OnClickLong()
    {
        Debug.Log("롱 슬라임 눌림");
        DontDestroyOnLoad(stageNumObject);
        character_type = 6;
        triger4 = true;
    }


}
