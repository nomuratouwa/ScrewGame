using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobScript : MonoBehaviour
{
    
    public float JumpHigh;      //�W�����v�̍���
    public int PyonKankaku;     //�҂�񂷂�Ԋu
    public float DieSpeed;

    private Rigidbody2D RB;
    private Animator anim = null;
    private GameObject SoundObject;
    private float Cnt1;             //�^�C���n�̌v�Z
    private float PyonRimit = 5;    //���Ɠ���
    [SerializeField] private bool Death = false;     //����ł邩�ǂ���
    private bool Ground = false;    //���n�ʂ�����

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SoundObject = GameObject.Find("OneShotSoundManager");
    }

    void FixedUpdate()
    {

        if (Ground && !Death && Cnt1 < PyonRimit)
            Jump();
        if (Death)
            DeathKansu();
        if (Cnt1 >= PyonRimit) Cnt1--;
    }

    void DeathKansu()           //���񂾌�̏���
    {
        //float posX = Random.Range(-1 * RandomSu, RandomSu);   //���񂾌�ɉ��ɗh���
        transform.Translate(0, 0.2f, 0f);
        RB.velocity = new Vector2(0, RB.velocity.y);  //��Ɉړ��@�����Ă���
        RB.gravityScale = 0;
    }



    void Jump()
    {
        RB.velocity = new Vector2(RB.velocity.x, 0);  //y���̗͂����Z�b�g
        RB.AddForce(transform.up * JumpHigh);           //��ɗ͂�������
        Cnt1 += PyonKankaku;
        Ground = false;
    }


    public void Die()       //���񂾏���
    {
        // RB.velocity = new Vector2(RB.velocity.x, 0);  //y���̗͂����Z�b�g
        anim.SetBool("Die", true);                                      //���ʃA�j��
        SoundObject.GetComponent<OneShotSoundManager>().PlaySound2();   //���ʂ���
        Death = true;

    }

    public void SpinAnim()  //���A�j���ɂ���
    {
        anim.SetTrigger("Spin");
    }

    //���n����
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ground"&&!Death)
        {
            SoundObject.GetComponent<OneShotSoundManager>().PlaySound1();       //���n��
            Ground = true;

        }
        if (col.gameObject.tag == "DieZone" || col.gameObject.tag == "Electrical" && !Death)        //�G��Ă͂����Ȃ�����
        {
            Die();
        }
    }

    void OnTriggerExit2D(Collider2D col)     //�n�ʂ��痣���
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

    void OnTriggerStay2D(Collider2D col)   //Enter�ł��܂������ł��Ȃ������ꍇ�̗\��
    {
        if (col.gameObject.tag == "Electrical" && !Death)       //���ʃM�~�b�N�ɐG�ꂽ����
        {
            Die();
        }
        if (col.gameObject.tag == "Ground" && !Ground)
        {
            // SoundObject.GetComponent<OneShotSoundManager>().PlaySound();
            Ground = true;
        }
    }
}
