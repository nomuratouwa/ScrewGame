using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimeScript : MonoBehaviour
{
    public Text CleartimeText;
    
    void Start()
    {
        float Time = TimeScript.GetTime();                                  //TimeScript����N���A�^�C�����擾
        CleartimeText.text = "�N���A�\�^�C���@�F�@" + Time.ToString("f2");     //�N���A�^�C����\������
        //print(Time);
    }

}
