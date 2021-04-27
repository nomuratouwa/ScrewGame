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
            //右入力で左向きに動く
            if (HorizontalKey > 0)
            {
                rb.velocity = new Vector2(Speed, Pyon);
                Cnt1+=PyonKankaku;
            }
            //左入力で左向きに動く
            else if (HorizontalKey < 0)
            {
                rb.velocity = new Vector2(-Speed, Pyon);
                Cnt1+=PyonKankaku;
            }
        }
        //ボタンを話すと止まる
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (Cnt1 >= PyonRimit)
                Cnt1--;
        }
    }
}