using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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

    // 物理演算をしたい場合はFixedUpdateを使うのが一般的
    void FixedUpdate()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        if (Cnt1 < pyonRimit)
        {
            //右入力で右向きに動く
            if (horizontalKey > 0)
            {
                rb.AddForce(transform.right * speed);
                rb.AddForce(transform.up * pyon);
                Cnt1 += pyonKankaku;
            }
            //左入力で左向きに動く
            else if (horizontalKey < 0)
            {
                rb.AddForce(-transform.right * speed);
                rb.AddForce(transform.up * pyon);
                Cnt1 += pyonKankaku;
            }
        }
        //ボタンを話すと止まる
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            if (Cnt1 >= pyonRimit)
                Cnt1--;
        }
    
    }
}