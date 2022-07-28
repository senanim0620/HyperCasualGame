using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audio;
    public AudioClip diesound;

    public float force; // ���� �����ϴ� ��
   
    private int jumpcount = 0; // ������ �� 1���� �����ϴ�
    public bool isDead = false; // �׾����� Ȯ���ϴ� Ʈ����
    public bool triger = false; // �浹�� �Ͼ���� Ȯ���ϴ� Ʈ����


    void Start()
    {
        audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (isDead)
            return;

        triger = false;
        if(Input.GetMouseButtonDown(0) && jumpcount < 1)
        {
            audio.Play();
            jumpcount++;
            gameObject.GetComponent<Rigidbody>().AddForce(0, force, 0);
            animator.SetBool("Jump",true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Jump", false);
        }
    }


    // �ݶ��̴��� ���� �浹���� �� �긯�� ���߸� �ȴ�. 
    private void OnCollisionEnter(Collision collision)
    {
        triger = true;
    
        if(collision.contacts[0].normal.y < 0.1f)
        {
            audio.PlayOneShot(diesound);
            Debug.Log("DIE");
            jumpcount = 0;
            Die();
  
        }

        if(collision.contacts[0].normal.y > 0.9f)
        {
            Debug.Log("���� ������!");
            jumpcount = 0;
        }


    }

    // �׾��� �� Ȯ���ϴ� �Լ�
    private void Die()
    {
       animator.SetTrigger("sena");
        isDead = true;

    }

    public static implicit operator PlayerController(GameObject v)
    {
        throw new NotImplementedException();
    }
}
