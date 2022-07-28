using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class OpeningManager : MonoBehaviour
{
    public GameObject stageNumObject;
    public CharacterChange character;
    public Canvas _character;
    public Canvas _opening;

    // Start is called before the first frame update
    void Start()
    {
 
        _opening.enabled = true;
        _character.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �������� ������
    public void OnClickGameStart()
    {
       if (character.triger4 == false)
            character.character_type = 0;
        Debug.Log("���� ����!");
        SceneManager.LoadScene(1);
        DontDestroyOnLoad(stageNumObject);
    }

    public void OnClickQuit()
    {
        Debug.Log("���� ����");
        Application.Quit();
    }


    public void OnClickCharacter()
    {
        _character.enabled = true;
        Debug.Log("ĳ���� ���� ȭ���� ���Ƚ��ϴ�");
        _opening.enabled = false;
       // character_type = 0;
    }

    public void close()
    {
        _character.enabled = false;
        Debug.Log("ĳ���� ���� ȭ���� �������ϴ�");
        _opening.enabled = true;
        // character_type = 0;
    }


}
