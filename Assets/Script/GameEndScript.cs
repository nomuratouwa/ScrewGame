using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))   //�G�X�P�[�v�L�[��
        {
            Application.Quit();             //�Q�[���𗎂Ƃ�
        }
    }
}
