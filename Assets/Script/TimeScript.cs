using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    
    public  float LimitTime = 5.0f;
    public static float NokoriTime;
    public float KikenTime = 20.0f;

    //時間を表示する変数
    public Text timeText;
    private GameObject BGMObject;
    private GameObject PlayerObject;
    private bool Sound = false;
    void Start()
    {
        //プレイヤーオブジェクト取得
        PlayerObject = GameObject.Find("driver");
        //BGMオブジェクト取得
        BGMObject = GameObject.Find("BGM");
        NokoriTime = LimitTime;
    }
    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        NokoriTime -= Time.deltaTime;

        //時間を表示する
        timeText.text = "のこり"+ NokoriTime.ToString("f2");

        if (NokoriTime <= KikenTime && !Sound)
        {
            LimitKiken();
        }
        //制限時間になった
        if (NokoriTime <= 0)
        {
            PlayerObject.GetComponent<PlayerController>().Die();
            timeText.text = ("のこり0.0");
        }
    }

    void LimitKiken()//制限時間残り・・・
    {
        Sound = true;
        GetComponent<AudioSource>().Play();  // 効果音を鳴らす
        BGMObject.GetComponent<AudioSource>().pitch = 1.2f;
    }
    
    public static float GetTime()
    {
        return NokoriTime;
    }
}