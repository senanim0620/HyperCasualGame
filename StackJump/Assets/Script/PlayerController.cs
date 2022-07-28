using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audio;
    public AudioClip diesound;

    public float force; // 위로 점프하는 힘
   
    private int jumpcount = 0; // 점프는 총 1번만 가능하다
    public bool isDead = false; // 죽었는지 확인하는 트리거
    public bool triger = false; // 충돌이 일어났는지 확인하는 트리거


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


    // 콜라이더가 둘이 충돌했을 때 브릭이 멈추면 된다. 
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
            Debug.Log("위에 안착함!");
            jumpcount = 0;
        }


    }

    // 죽었는 지 확인하는 함수
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
