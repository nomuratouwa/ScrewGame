using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    
    public  float LimitTime = 5.0f;     //��������
    public static float NokoriTime;     //���U���g�ŕ\�����邽�߂�static�@����ȊO�Ŏg��Ȃ��i�\��j
    public float KikenTime = 20.0f;     //�����ɋ߂Â��Ă��̉��o����^�C��

    //���Ԃ�\������ϐ�
    public Text timeText;

    private bool Over = false;
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
            timeText.text = ("�̂���0.0");
            if (!Over)
                LimitOver();
        }
    }

    void LimitKiken()//�������Ԏc��E�E�E
    {
        Sound = true;
        GetComponent<AudioSource>().Play();  // ���ʉ���炷
        BGMObject.GetComponent<AudioSource>().pitch = 1.2f;
    }

    void LimitOver()        //���ԃI�[�o�[
    {
        Over = true;
        PlayerObject.GetComponent<PlayerController>().Die();
    }
    
    public static float GetTime()   //���Ԃ̃Q�b�^�[
    {
        return NokoriTime;
    }
}