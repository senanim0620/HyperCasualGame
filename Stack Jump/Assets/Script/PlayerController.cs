using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player;
    private Animator animator;
    public float force;
    public bool triger=false;
    private int jumpcount = 0;
    

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        triger = false;
        if(Input.GetMouseButtonDown(0) && jumpcount < 1)
        {
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
            Debug.Log("DIE");
            jumpcount = 0;
        }

        if(collision.contacts[0].normal.y > 0.9f)
        {
            Debug.Log("���� ������!");
            jumpcount = 0;
        }


    }

}
