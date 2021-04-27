using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;     //はやさ
    public float Jump;      //ジャンプの高さ
    public float Pyon;      //移動するときのぴょんするときの高さ
    public int PyonKankaku; //ぴょんする間隔

    private Rigidbody2D RB;
    private float Cnt1;     //ぴょん間隔の計算
    private float PyonRimit = 1;//↑と同じ
    private bool Ground = true;  //今地面足ついてる？true そう false ちがいます

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float VerticalKey = Input.GetAxis("Vertical");
        if (Cnt1 < PyonRimit && HorizontalKey!=0)
        {
            Move(HorizontalKey);
        }
        //何も押さないとｘ座標だけ止まる
        else
        {
            RB.velocity = new Vector2(0, RB.velocity.y);
            if (Cnt1 >= PyonRimit) Cnt1--;
        }
        if (Ground　&& VerticalKey > 0)
        {
            RB.AddForce(transform.up * Jump);
            Ground = false;
        }
    }
    void Move(float Key)
    {
        //右入力で右向きに動く
        if (Key > 0)
        {
            RB.AddForce(transform.right * Speed);
            Cnt1 += PyonKankaku;
        }
        //左入力で左向きに動く
        else if (Key < 0)
        {
            RB.AddForce(-transform.right * Speed);
            Cnt1 += PyonKankaku;
        }
        if (Ground)
        {
            RB.AddForce(transform.up * Pyon);
        }
    }
    //着地判定
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (!Ground)
                Ground = true;
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (!Ground)
                Ground = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (Ground)
                Ground = false;
        }
    }
}
