using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public GameObject[] stageButtons;   //�X�e�[�W�I���{�^���z��

    // Start is called before the first frame update
    void Start()
    {
        //�ǂ��܂ŃN���A���Ă���̂�
        //int clearStageNo = PlayerPrefs.GetInt("clear", 0);


        //�X�e�[�W�{�^����L����
        for (int i = 0; i <= stageButtons.GetUpperBound(0); i++)
        {
            bool b;


          //  if (clearStageNo < 1)
         //   {
         //       b = false;
         //   }
       //     else
       //     {
                b = true;
       // //    }

            //�{�^���̗L���A������ݒ�
            stageButtons[i].GetComponent<Button>().interactable = b;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    //�X�e�[�W�I��
    public void PushStageSelectButton(int stageNo)
    {
        SceneManager.LoadScene("STAGE" + stageNo);
    }
    public void PushTutlialButton()
    {
        SceneManager.LoadScene("Sousahouhou");
    }
}
