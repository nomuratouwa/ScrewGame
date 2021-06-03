using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{
    
    public float JumpHigh;      //ジャンプの高さ
    public int PyonKankaku;     //ぴょんする間隔
    public float DieSpeed;

    private Rigidbody2D RB;
    private Animator anim = null;
    private GameObject SoundObject;
    private float Cnt1;             //タイム系の計算
    private float PyonRimit = 5;    //↑と同じ
    [SerializeField] private bool Death = false;     //死んでるかどうか
    private bool Ground = false;    //今地面か判定

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SoundObject = GameObject.Find("OneShotSoundManager");
    }

    void FixedUpdate()
    {

        if (Ground && !Death && Cnt1 < PyonRimit)
            Jump();
        if (Death)
            DeathKansu();
        if (Cnt1 >= PyonRimit) Cnt1--;
    }

    void DeathKansu()           //死んだ後の処理
    {
        //float posX = Random.Range(-1 * RandomSu, RandomSu);   //死んだ後に横に揺れる
        transform.Translate(0, 0.2f, 0f);
        RB.velocity = new Vector2(0, RB.velocity.y);  //上に移動　成仏てきな
        RB.gravityScale = 0;
    }



    void Jump()
    {
        RB.velocity = new Vector2(RB.velocity.x, 0);  //y軸の力をリセット
        RB.AddForce(transform.up * JumpHigh);           //上に力を加える
        Cnt1 += PyonKankaku;
        Ground = false;
    }


    public void Die()       //死んだ処理
    {
        // RB.velocity = new Vector2(RB.velocity.x, 0);  //y軸の力をリセット
        anim.SetBool("Die", true);                                      //死ぬアニメ
        SoundObject.GetComponent<OneShotSoundManager>().PlaySound2();   //しぬおと
        Death = true;

    }

    public void SpinAnim()  //回るアニメにする
    {
        anim.SetTrigger("Spin");
    }

    //着地判定
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground"&&!Death)
        {
            SoundObject.GetComponent<OneShotSoundManager>().PlaySound1();       //着地音
            Ground = true;

        }
        if (col.gameObject.tag == "DieZone" || col.gameObject.tag == "Electrical" && !Death)        //触れてはいけないもの
        {
            Die();
        }
    }

    void OnTriggerExit2D(Collider2D col)     //地面から離れる
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

    void OnTriggerStay2D(Collider2D col)   //Enterでうまく処理できなかった場合の予備
    {
        if (col.gameObject.tag == "Electrical" && !Death)       //死ぬギミックに触れた処理
        {
            Die();
        }
        if (col.gameObject.tag == "Ground" && !Ground)
        {
            // SoundObject.GetComponent<OneShotSoundManager>().PlaySound();
            Ground = true;
        }
    }
}
