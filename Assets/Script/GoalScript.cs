using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{

    public int StageNo; //�X�e�[�W�i���o�[

    //public GameObject GoalObject;
    public GameObject SceneMangaer;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "driver")
        {
            //�Z�[�u�f�[�^�X�V
            //if (PlayerPrefs.GetInt("CLEAR", 0) < StageNo)
            //{
               //PlayerPrefs.SetInt("CLEAR", StageNo);   //�X�e�[�W�i���o�[�L��
            //}

            //�Q�[���N���A�e�L�X�g��\��
         //   GoalObject.GetComponent<Text>();
        //    GoalObject.SetActive(true);

            SceneMangaer.GetComponent<StageScene>().ClearScene();

            // 3�b�ŃN���A��ʂɑJ��
            //SceneManager.LoadScene("ClearScene", 3.0f);
        }
    }
}
