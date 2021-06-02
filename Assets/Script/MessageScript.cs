using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScript : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float FeedTime = 0.01f;      //すけるorすけないまでの時間

    private bool PlayerHantei = false;

    void Start()
    {
        canvasGroup.alpha = 0f;         //開始時には透明に
    }

   
    void Update()
    {
        if (PlayerHantei)       //近くにプレイヤーがいる
        {
            if (canvasGroup.alpha < 1.0f)           //100%現れるまで
                canvasGroup.alpha += FeedTime;      //透明ドを下げる
        }
        else
        {
            if (canvasGroup.alpha > 0.0f)           //上の逆
                canvasGroup.alpha -= FeedTime;
        }
    }
    void OnTriggerEnter2D(Collider2D col)           //近くにプレイヤーがいるか
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            PlayerHantei = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            PlayerHantei = false;
        }
    }
}
