using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiClick : MonoBehaviour
{
    public GameObject NejiPrefab;

    GameObject OyaObject;
    GameObject PlayerObject;
    bool Fit = true;                            //ねじがはまっているかどうか
    [SerializeField] bool Removefrag = false;   //近くに主人公がいるか
    [SerializeField] bool Naka = false;         //なかのねじか

    public Sprite SpriteNeji;
    public Sprite SpriteNejiana;
    
    void Start()
    {
        OyaObject = transform.parent.gameObject; //親オブジェクト取得
        PlayerObject = GameObject.Find("driver");//プレイヤーオブジェクト取得
    }

    //クリックされると
    public void Click()
    {

        if (Fit && Removefrag)
        {
            PlayerObject.GetComponent<PlayerController>().SpinAnim();                           //主人公に回るアニメーションをさせる
            OyaObject.GetComponent<NejiController>().HingeEnabledComponent(this.gameObject);        //ヒンゲジョインントを無効にさせる
            if (Naka)
                OyaObject.GetComponent<NejiController>().FixedEnabledComponent(this.gameObject);    //中ならフィクセドジョイントも無効
            this.gameObject.GetComponent<SpriteRenderer>().sprite = SpriteNejiana;                  //
            GameObject HazushiNeji = Instantiate(NejiPrefab, transform.position, Quaternion.identity);//ねじ飛ばすプレハブ
            Fit = false;                                                                            //ネジをはずす
        }
    }

    void OnTriggerEnter2D(Collider2D col)           //プレイヤーが近くにいるか
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            Removefrag = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "NejiHazushi")
        {
            Removefrag = false;
        }
    }
}
