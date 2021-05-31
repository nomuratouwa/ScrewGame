using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    
    public  float LimitTime = 5.0f;
    public static float NokoriTime;
    public float KikenTime = 20.0f;

    //���Ԃ�\������ϐ�
    public Text timeText;
    private GameObject BGMObject;
    private GameObject PlayerObject;
    private bool Sound = false;
    void Start()
    {
        //�v���C���[�I�u�W�F�N�g�擾
        PlayerObject = GameObject.Find("driver");
        //BGM�I�u�W�F�N�g�擾
        BGMObject = GameObject.Find("BGM");
        NokoriTime = LimitTime;
    }
    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        NokoriTime -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = "�̂���"+ NokoriTime.ToString("f2");

        if (NokoriTime <= KikenTime && !Sound)
        {
            LimitKiken();
        }
        //�������ԂɂȂ���
        if (NokoriTime <= 0)
        {
            PlayerObject.GetComponent<PlayerController>().Die();
            timeText.text = ("�̂���0.0");
        }
    }

    void LimitKiken()//�������Ԏc��E�E�E
    {
        Sound = true;
        GetComponent<AudioSource>().Play();  // ���ʉ���炷
        BGMObject.GetComponent<AudioSource>().pitch = 1.2f;
    }
    
    public static float GetTime()
    {
        return NokoriTime;
    }
}