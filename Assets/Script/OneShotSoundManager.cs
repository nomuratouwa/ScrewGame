using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ���N���b�N������A���ʉ���炷
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();  // ���ʉ���炷
        }
    }
}