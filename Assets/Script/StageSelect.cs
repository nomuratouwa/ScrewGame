using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{

    public GameObject[] stageButtons;   //ステージ選択ボタン配列

    // Start is called before the first frame update
    void Start()
    {
        //どこまでクリアしているのか
        //int clearStageNo = PlayerPrefs.GetInt("clear", 0);


        //ステージボタンを有効化
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

            //ボタンの有効、無効を設定
            stageButtons[i].GetComponent<Button>().interactable = b;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    //ステージ選択
    public void PushStageSelectButton(int stageNo)
    {
        SceneManager.LoadScene("STAGE" + stageNo);
    }
    public void PushTutlialButton()
    {
        SceneManager.LoadScene("Sousahouhou");
    }
}
