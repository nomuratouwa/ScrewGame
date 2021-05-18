using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuiteku : MonoBehaviour
{
    [SerializeField] GameObject TuitekuObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {
        // transformを取得
        Transform myTransform = this.transform;
        // ローカル座標を基準に、座標を取得
        Vector3 localPos = myTransform.localPosition;
        Vector3 TuitekuPos = TuitekuObject.transform.localPosition;
        localPos =  TuitekuPos;        //座標指定
        myTransform.localPosition = localPos; // ローカル座標での座標を設定
    }
}
