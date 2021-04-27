using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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

    // 物理演算をしたい場合はFixedUpdateを使うのが一般的
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        float VerticalKey = Input.GetAxis("Vertical");
        if (Cnt1 < PyonRimit)
        {
            //右入力で右向きに動く
            if (horizontalKey > 0)
            {
                rb.AddForce(transform.right * Speed);
                rb.AddForce(transform.up * Pyon);
                Cnt1 += PyonKankaku;
            }
            //左入力で左向きに動く
            else if (horizontalKey < 0)
            {
                rb.AddForce(-transform.right * Speed);
                rb.AddForce(transform.up * Pyon);
                Cnt1 += PyonKankaku;
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