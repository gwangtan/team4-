using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dongle : MonoBehaviour
{
    public int level;
    public bool isDrag;
    Rigidbody2D rigid;
    Animator anim;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    private void OnEnable()
    {
        anim.SetInteger("Level", level);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDrag)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //x축 경계 설정
            float leftBorder = -4.7F + transform.localScale.x / 2f;
            float rightBorder = 4.7F - transform.localScale.x / 2f;

            if (mousePos.x < leftBorder)
            {
                mousePos.x = leftBorder;
            }
            else if (mousePos.x > rightBorder)
            {
                mousePos.x = rightBorder;
            }

            mousePos.y = 5;     //떨어지는 위치 설정
            mousePos.z = 0;     //z축 설정
            transform.position = Vector3.Lerp(transform.position, mousePos, 0.2f);   //0부터 1 사이값(구슬이 마우스를 향해 천천히 따라옴)
        }
    }

    //드래그 앤 드랍
    public void Drag()
    {
        isDrag = true;
       
    }

    public void Drop()
    {
        isDrag = false;
        rigid.simulated = true;

    }


}
