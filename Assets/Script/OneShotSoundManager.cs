using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource Source;//AudioSource

    [SerializeField] private AudioClip Clip1;//���ʉ�1 ����
    [SerializeField] private AudioClip Clip2;//���ʉ�2 ���_�ā�)���
    /*
    // Update is called once per frame
    void Update()
    {
        // ���ړ�������A���ʉ���炷
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
        }

        // ���ړ�������A���ʉ���炷(�����������ꍇ)
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
        }
    }*/
    public void PlaySound1()
    {
        Source.PlayOneShot(Clip1);  // ���ʉ���炷
    }
    public void PlaySound2()
    {
        Source.PlayOneShot(Clip2);  // ���ʉ���炷
    }
}