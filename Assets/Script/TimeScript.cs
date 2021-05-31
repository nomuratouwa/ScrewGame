using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float LimitTime = 5.0f;

    //���Ԃ�\������ϐ�
    public Text timeText;
    private GameObject PlayerObject;
    private bool Sound = false;
    void Start()
    {
        //�v���C���[�I�u�W�F�N�g�擾
        PlayerObject = GameObject.Find("driver");
    }
    // Update is called once per frame
    void Update()
    {
        //���Ԃ��J�E���g�_�E������
        LimitTime -= Time.deltaTime;

        //���Ԃ�\������
        timeText.text = "�̂���"+LimitTime.ToString("f1");

        if (LimitTime <= 10&&!Sound)
        {
            Sound = true;
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
        }
        //�������ԂɂȂ���
        if (LimitTime <= 0)
        {
            PlayerObject.GetComponent<PlayerController>().Die();
            timeText.text = ("�̂���0.0");
        }
    }
}