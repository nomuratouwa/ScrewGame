using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuiteku : MonoBehaviour
{
    [SerializeField] GameObject TuitekuObject;  //ついていきたいオブジェクト

    void LateUpdate()
    {
        // transformを取得
        Transform myTransform = this.transform;
        // ローカル座標を基準に、座標を取得
        Vector3 localPos = myTransform.localPosition;
        Vector3 TuitekuPos = TuitekuObject.transform.localPosition;//ついてくオブジェクトの座標取得
        localPos =  TuitekuPos;        //ついてくオブジェクトの座標に指定
        myTransform.localPosition = localPos; // 自分のローカル座標を変える

    }
}
