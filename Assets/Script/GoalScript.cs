using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
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
            //ゲームクリアテキストを表示
            GoalObject.GetComponent<Text>();
            GoalObject.SetActive(true);

        }
    }
}
