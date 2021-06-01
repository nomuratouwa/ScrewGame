using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElekEffectScript : MonoBehaviour
{
    public int ElekTime;      //電気の強さ
    private ElectricScript Script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ElekTime > 0)
        {
                ElekTime--;
                transform.Find("LIGHTNING").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("LIGHTNING").gameObject.SetActive(false);

        }

        //↓何故か親子関係でもワールド座標に固定化されてしまうのでローカル座標を固定する
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
            Script = col.gameObject.GetComponent<ElectricScript>();
            ElekTime = Script.ElekTime;         //となりの電気の強さをコピーする
        }
    }
}
