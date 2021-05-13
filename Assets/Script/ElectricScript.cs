using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricScript : MonoBehaviour
{
    public int ElekTime = 100;
    public  bool Minamoto = false;
    public Sprite Sunder;
    private ElectricScript Script;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ElekTime>0)
        {
            this.tag = "Electrical";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sunder;
            if (!Minamoto)
                ElekTime--;
        }
        else
        {
            this.tag = "Untagged";
            this.gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }

        // transformを取得
        Transform myTransform = this.transform;

        // ローカル座標を基準に、座標を取得
        Vector3 localPos = myTransform.localPosition;
        localPos = new Vector3(0, 0, 0);        //原点に固定
        myTransform.localPosition = localPos; // ローカル座標での座標を設定
        Vector3 localRot = myTransform.localEulerAngles;
        localRot = new Vector3(0, 0, 0);        //原点に固定
        myTransform.localEulerAngles = localRot; //ローカル座標での回転を設定

    }

    //他オブジェクトが触れている間
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Electrical")
        {
            Debug.Log("Test!!!!!!!!");
            Script = col.gameObject.GetComponent<ElectricScript>();
            if (Script.ElekTime > 0 && !Minamoto)
            {
                ElekTime = Script.ElekTime;
            }

        }
    }
}
