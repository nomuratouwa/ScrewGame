using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public GameObject[] stageButtons;   //�X�e�[�W�I���{�^���z��
    public int clearStageNo;
    public GameObject SaveObj;
    public GameObject sakujoPanel;

    // Start is called before the first frame update
    void Start()
    {
        //�ǂ��܂ŃN���A���Ă���̂�
                clearStageNo = SaveObj.GetComponent<SaveManager>().OnLoad();


        //�X�e�[�W�{�^����L����
        for (int i = 0; i <= stageButtons.GetUpperBound(0); i++)
        {
            bool b;


            if (clearStageNo < i)
           {
                b = false;
            }
           else
            {
                b = true;
            }

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
    public void ResetButton()
    {
        SaveObj.GetComponent<SaveManager>().OnSave(0);   //�X�e�[�W�i���o�[�L��
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void sakujoSimasuka()
    {
        sakujoPanel.SetActive(true);
    }
    public void noSakujo()
    {
        sakujoPanel.SetActive(false);
    }
}
