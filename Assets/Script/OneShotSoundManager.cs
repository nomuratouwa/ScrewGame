using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneShotSoundManager : MonoBehaviour
{
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
    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();  // ���ʉ���炷
    }
}