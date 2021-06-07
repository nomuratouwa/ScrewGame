using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NejiController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject RightNejiObject = GameObject.Find("RightNeji");  //右ねじobject取得
        GameObject LeftNejiObject = GameObject.Find("LeftNeji");    //左ねじobject取得

    }
    
    public void HingeEnabledComponent(GameObject gameObject)    //ヒンゲジョイント無効
    {
        var HingeJoint = gameObject.GetComponent<HingeJoint2D>();
        HingeJoint.enabled = false;
    }

    public void GyakuEnabledComponent(GameObject gameObject)   //ヒンゲジョイント有効
    {
        var HingeJoint = gameObject.GetComponent<HingeJoint2D>();
        HingeJoint.enabled = true;
    }
    public void FixedEnabledComponent(GameObject gameObject)    //ヒンゲジョイント無効
    {
        var FixedJoint = gameObject.GetComponent<FixedJoint2D>();
        FixedJoint.enabled = false;
    }
}
