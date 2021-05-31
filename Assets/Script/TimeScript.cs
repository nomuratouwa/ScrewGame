using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float LimitTime = 5.0f;

    //時間を表示する変数
    public Text timeText;
    private GameObject PlayerObject;
    private bool Sound = false;
    void Start()
    {
        //プレイヤーオブジェクト取得
        PlayerObject = GameObject.Find("driver");
    }
    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        LimitTime -= Time.deltaTime;

        //時間を表示する
        timeText.text = "のこり"+LimitTime.ToString("f1");

        if (LimitTime <= 10&&!Sound)
        {
            Sound = true;
            GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        }
        //制限時間になった
        if (LimitTime <= 0)
        {
            PlayerObject.GetComponent<PlayerController>().Die();
            timeText.text = ("のこり0.0");
        }
    }
}