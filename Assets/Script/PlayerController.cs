
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;         //はやさ
    public float JumpHigh;      //ジャンプの高さ
    public float Pyon;          //移動するときのぴょんするときの高さ
    public int PyonKankaku;     //ぴょんする間隔
    public float RandomSu;      //ランダム

    private Rigidbody2D RB;
    private Animator anim = null;
    private GameObject SceneMangaer;
    private GameObject SoundObject;
    private float Cnt1;             //タイム系の計算1
    private float Cnt2 = 0;         //タイム系の計算2
    private float PyonRimit = 1;    //↑と同じ
    private float DeathTime = 3;    //死んでシーンリセットする時間
    private bool Death = false;     //死んでるかどうか
    private bool Ground = false;    //今地面か判定

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SceneMangaer = GameObject.Find("SceneManager");
        SoundObject = GameObject.Find("OneShotSoundManager");
    }

    void FixedUpdate()
    {

        switch (Death)          //生きてるかどうか
        {
            case true:
                DeathKansu();   //死
                break;
            case false:
                LifeKansu();    //生
                break;
        }
        if (Cnt1 >= PyonRimit) Cnt1--;
        if (Cnt2 >= PyonRimit) Cnt2--;
    }

    void DeathKansu()           //死んだ後の処理
    {
        //float posX = Random.Range(-1 * RandomSu, RandomSu);   //死んだ後に横に揺れる
        transform.Translate(0, 0.1f, 0f);
        RB.velocity = new Vector2(0, RB.velocity.y);  //上に移動　成仏てきな
        RB.gravityScale = 0;
        DeathTime -= Time.deltaTime;
        if (DeathTime <= 0)
            SceneMangaer.GetComponent<scene>().RelordScene();//Sceneリセット
    }

    void LifeKansu()
    {
        //入力情報
        float HorizontalKey = Input.GetAxis("Horizontal");
        float VerticalKey = Input.GetAxis("Vertical");

        //移動
        if (Cnt1 < PyonRimit && HorizontalKey != 0)
        {
            Move(HorizontalKey);
        }

        //何も押さないとｘ座標だけ止まる
        else
        {
            RB.velocity = new Vector2(0, RB.velocity.y);
            anim.SetBool("walk", false);                  //アニメを立ちに
        }

        if (Cnt2 < PyonRimit && Ground && VerticalKey > 0)//ジャンプ （Cnt2力を複数重ねないように）
        {
            Jump();
        }

        if (Input.GetButtonDown("Relord"))  //自殺
        {
            Die();
        }
    }

    void Move(float Key)        //移動する関数
    {

        Vector3 Muki = this.transform.localEulerAngles;     //向きを変える変数
        anim.SetBool("walk", true);         //アニメセット
        //右入力で右向きに移動
        if (Key > 0)
        {
            Muki.y = 0.0f;
            RB.AddForce(transform.right * Speed);
            Cnt1 += PyonKankaku;        //移動処理が1フレームごとにならないように

        }
        //左入力で左向きに移動
        else if (Key < 0)
        {

            Muki.y = 180.0f;
            RB.AddForce(transform.right * Speed);
            Cnt1 += PyonKankaku;        //移動処理が1フレームごとにならないように
        }
        if (Ground)
        {
            RB.velocity = new Vector2(RB.velocity.x, 0);     //y軸の力をリセット
            RB.AddForce(transform.up * Pyon);                //はねる
        }
        transform.localEulerAngles = Muki;
    }

    void Jump()
    {
        RB.velocity = new Vector2(RB.velocity.x, 0);  //y軸の力をリセット
        RB.AddForce(transform.up * JumpHigh);           //上に力を加える
        Cnt1 += PyonKankaku;
        Cnt2 += PyonKankaku;
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
        if (col.gameObject.tag == "Ground" && !Death)
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
        if (col.gameObject.tag == "Ground"&&!Ground)   
        {
           // SoundObject.GetComponent<OneShotSoundManager>().PlaySound();
            Ground = true;
        }
    }
}
