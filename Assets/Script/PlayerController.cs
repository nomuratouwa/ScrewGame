
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
    private Animator anim = null;
    private float Cnt1;     //ぴょん間隔の計算
    private float PyonRimit = 1;//↑と同じ
    private bool Death = false;
    private bool Ground = true;  //今地面と足ついてる？true そう false ちがいます
    [SerializeField]  private Sprite DeathDriver;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float HorizontalKey = Input.GetAxis("Horizontal");
        float VerticalKey = Input.GetAxis("Vertical");
        switch (Death)
        {
            case true:
                DeathKansu();
                break;
            case false:
                if (Cnt1 < PyonRimit && HorizontalKey != 0)
                {
                    anim.SetBool("walk", true);
                    Move(HorizontalKey);
                }
                //何も押さないとｘ座標だけ止まる
                else
                {
                    RB.velocity = new Vector2(0, RB.velocity.y);
                    if (Cnt1 >= PyonRimit) Cnt1--;
                    anim.SetBool("walk", false);
                }
                if (Ground && VerticalKey > 0)//ジャンぷ
                {
                    RB.AddForce(transform.up * Jump);
                    Cnt1 += PyonKankaku;
                    Ground = false;
                }
                break;

        }
    }
    void Move(float Key)
    {
        Vector3 Muki = this.transform.localEulerAngles; ;
        //右入力で右向きに動く
        if (Key > 0)
        {
            Muki.y = 0.0f;
            RB.AddForce(transform.right * Speed);
            Cnt1 += PyonKankaku;

        }
        //左入力で左向きに動く
        else if (Key < 0)
        {

            Muki.y = 180.0f;
            RB.AddForce(transform.right * Speed);
            Cnt1 += PyonKankaku;
        }
        if (Ground)
        {
            RB.AddForce(transform.up * Pyon);
        }
        transform.localEulerAngles = Muki;
    }

    public void SpinAnim()
    {
        anim.SetTrigger("Spin");
    }

    void Die()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = DeathDriver;
        anim.SetBool("Die", true);
        Death = true;
    }
    void DeathKansu()
    {
        transform.Translate(0f, 0.1f, 0f);
        RB.velocity = new Vector2(0, RB.velocity.y);
        RB.gravityScale = 0;
    }
    //着地判定
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (!Ground)
                Ground = true;
        }
        if (col.gameObject.tag == "DieZone" || col.gameObject.tag == "Electrical")
        {
            Die();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            if (Ground)
            {
                anim.SetBool("walk", true);
                Ground = false;
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Electrical")
        {
            Die();
        }
    }
}
