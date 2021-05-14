using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Speed;
    public float Pyon;
    public int PyonKankaku;
    private Rigidbody2D rb;
    private float Cnt1;
    private float PyonRimit = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float VerticalKey = Input.GetAxis("Vertical");

        if (Cnt1 < PyonRimit)
        {
            //�E���͂ō������ɓ���
            if (HorizontalKey > 0)
            {
                rb.velocity = new Vector2(Speed, Pyon);
                Cnt1+=PyonKankaku;
            }
            //�����͂ō������ɓ���
            else if (HorizontalKey < 0)
            {
                rb.velocity = new Vector2(-Speed, Pyon);
                Cnt1+=PyonKankaku;
            }
        }
        //�{�^����b���Ǝ~�܂�
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (Cnt1 >= PyonRimit)
                Cnt1--;
        }
    }
}