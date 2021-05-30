using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{

    public int StageNo; //ステージナンバー

    public GameObject GoalObject;
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
            //セーブデータ更新
            //if (PlayerPrefs.GetInt("CLEAR", 0) < StageNo)
            //{
               //PlayerPrefs.SetInt("CLEAR", StageNo);   //ステージナンバー記憶
            //}

            //ゲームクリアテキストを表示
            GoalObject.GetComponent<Text>();
            GoalObject.SetActive(true);

            // 3秒でクリア画面に遷移
            //SceneManager.LoadScene("ClearScene", 3.0f);
        }
    }
}
