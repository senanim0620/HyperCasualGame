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
        Debug.Log("ŷ������ ����");
        DontDestroyOnLoad(stageNumObject);
        character_type = 0;
        triger4 = true;
    }

    public void OnClickLeft()
    {
        Debug.Log("���������� ����");
        
        character_type = 6;
        DontDestroyOnLoad(stageNumObject);
        triger4 = true;
    }

    public void OnClickMetal()
    {
        Debug.Log("��Ż������ ����"); 
        DontDestroyOnLoad(stageNumObject);       
        character_type = 2;
        triger4 = true;
    }
    public void OnClickMokoko()
    {
        Debug.Log("������ ������ ����");
        DontDestroyOnLoad(stageNumObject);
        character_type = 6;
        triger4 = true;
    }

    public void OnClickPlane()
    {
        Debug.Log("�÷��� ������ ����");
        DontDestroyOnLoad(stageNumObject);
        character_type = 1;
        triger4 = true;
    }

    public void OnClickViking()
    {
        Debug.Log("����ŷ ������ ����");
        DontDestroyOnLoad(stageNumObject);
        character_type = 3;
        triger4 = true;
    }

    public void OnClickLong()
    {
        Debug.Log("�� ������ ����");
        DontDestroyOnLoad(stageNumObject);
        character_type = 6;
        triger4 = true;
    }


}
