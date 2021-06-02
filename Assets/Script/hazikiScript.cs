using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazikiScript : MonoBehaviour
{
    [SerializeField] private float Takasa = 100;    //���ɔ�ԋ����̍ő�l
    [SerializeField] private float Yoko = 100;      //���ɔ�ԋ����̍ő�l
    private Rigidbody2D RB;

    void Start()
    {
        Takasa = Random.Range(0, Takasa);           //���̋����������_����
        Yoko = Random.Range(-1 * Yoko, Yoko);       //���E�̋����������_����
        RB = GetComponent<Rigidbody2D>();
        RB.AddForce(transform.up * Takasa);         //������̗͂�������
        RB.AddForce(transform.right * Yoko);        //�������ɗ͂�������
        RB.AddTorque(-Yoko);                        //��]�ɕϐ�Yoko�̃}�C�i�X�̗͂�������i�}�C�i�X���ƃC�C�����ɉ�]���Ă����j
    }
    
}
