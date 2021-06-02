using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageScript : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float FeedTime = 0.01f;      //������or�����Ȃ��܂ł̎���

    private bool PlayerHantei = false;

    void Start()
    {
        canvasGroup.alpha = 0f;         //�J�n���ɂ͓�����
    }

   
    void Update()
    {
        if (PlayerHantei)       //�߂��Ƀv���C���[������
        {
            if (canvasGroup.alpha < 1.0f)           //100%�����܂�
                canvasGroup.alpha += FeedTime;      //�����h��������
        }
        else
        {
            if (canvasGroup.alpha > 0.0f)           //��̋t
                canvasGroup.alpha -= FeedTime;
        }
    }
    void OnTriggerEnter2D(Collider2D col)           //�߂��Ƀv���C���[�����邩
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
