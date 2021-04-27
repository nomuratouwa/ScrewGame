using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public float pyon;
    public int pyonKankaku;
    private Rigidbody2D rb;
    private float Cnt1;
    private float pyonRimit = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");

        if (Cnt1 < pyonRimit)
        {
            //�E���͂ō������ɓ���
            if (horizontalKey > 0)
            {
                rb.velocity = new Vector2(speed, pyon);
                Cnt1+=pyonKankaku;
            }
            //�����͂ō������ɓ���
            else if (horizontalKey < 0)
            {
                rb.velocity = new Vector2(-speed, pyon);
                Cnt1+=pyonKankaku;
            }
        }
        //�{�^����b���Ǝ~�܂�
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (Cnt1 >= pyonRimit)
                Cnt1--;
        }
    }
}