using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimeScript : MonoBehaviour
{
    public Text CleartimeText;
    
    void Start()
    {
        float Time = TimeScript.GetTime();                                  //TimeScriptからクリアタイムを取得
        CleartimeText.text = "クリア―タイム　：　" + Time.ToString("f2");     //クリアタイムを表示する
        //print(Time);
    }

}
